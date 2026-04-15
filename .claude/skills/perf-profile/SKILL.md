---
name: perf-profile
description: "Analyze performance of a system or scene, identify bottlenecks, and recommend optimizations for Flax Engine."
argument-hint: "<system or scene to profile>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Performance Profile Skill

## Purpose
Analyze game performance, identify bottlenecks, and recommend Flax Engine-specific optimizations to hit the 60fps target.

## Workflow

### Step 1: Identify Target
- Determine what to profile: specific system, scene, or full game
- Read relevant source code from `GameProject/Source/Game/`
- Read performance budgets from `.claude/docs/technical-preferences.md`

### Step 2: Static Analysis
Analyze code for common Flax performance issues:

**CPU Bottlenecks**:
- [ ] Allocations in `OnUpdate()` / `OnFixedUpdate()` (GC pressure)
- [ ] LINQ in hot paths
- [ ] String concatenation in loops
- [ ] Excessive `Actor.Find*` calls (cache references)
- [ ] Missing delta time scaling
- [ ] Unnecessary `GetComponent<T>()` calls per frame
- [ ] Heavy logic in `OnEnable()` / `OnStart()`

**GPU Bottlenecks**:
- [ ] Overdraw from overlapping transparent materials
- [ ] Excessive post-processing effects
- [ ] Unoptimized shaders (complex Visject graphs)
- [ ] Too many real-time lights (shadow-casting)
- [ ] Missing LOD on models
- [ ] Texture streaming not configured

**Memory Bottlenecks**:
- [ ] Large textures without compression
- [ ] Unstreamed audio clips
- [ ] Leaked actors/objects not destroyed
- [ ] Prefab instantiation spikes

### Step 3: Generate Report
Create `production/perf/PERF-{date}-{target}.md`:

```markdown
# Performance Report: {Target}
**Date**: {YYYY-MM-DD}
**Target FPS**: 60 (16.67ms frame budget)

## Summary
{Overall assessment: within budget / at risk / over budget}

## CPU Analysis
| Issue | Location | Impact | Recommendation |
|-------|----------|--------|----------------|

## GPU Analysis
| Issue | Location | Impact | Recommendation |
|-------|----------|--------|----------------|

## Memory Analysis
| Issue | Location | Impact | Recommendation |
|-------|----------|--------|----------------|

## Optimization Recommendations
### Quick Wins (< 1 hour)
1. {recommendation}

### Medium Effort (1-4 hours)
1. {recommendation}

### Significant Refactor (> 4 hours)
1. {recommendation}

## Flax-Specific Optimizations
- Use `FlaxObjectPool` for frequently spawned actors
- Enable GPU instancing on repeated materials
- Use Flax's built-in LOD system for models
- Configure texture streaming in Content settings
- Use `Profiler.BeginEvent()` / `EndEvent()` for custom markers
- Consider DLSS/FSR plugins for GPU-bound scenes
```

### Step 4: Create Stories
If optimizations are needed, create stories in `production/stories/` for each recommendation.

## Output
- `production/perf/PERF-{date}-{target}.md`
- Optional: optimization stories
