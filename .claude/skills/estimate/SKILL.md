---
name: estimate
description: "Estimate effort for a feature, story, or system using planning poker-style points with Flax-specific complexity factors."
argument-hint: "<feature or story to estimate>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Estimate Skill

## Purpose
Provide effort estimates for features, stories, or systems accounting for Flax Engine-specific complexity.

## Point Scale
| Points | Effort | Description |
|--------|--------|-------------|
| 1 | < 1 hour | Trivial change, single file |
| 2 | 1-2 hours | Small feature, 2-3 files |
| 3 | 2-4 hours | Moderate feature, some complexity |
| 5 | 4-8 hours | Significant feature, multiple systems |
| 8 | 1-2 days | Large feature, architectural impact |
| 13 | 2-4 days | Very large, split recommended |
| 21 | 1 week+ | Epic-level, must be broken down |

## Complexity Factors (Flax-Specific)
Add complexity for:
- **New Scene Setup** (+1): Requires new scene with actors and configuration
- **Custom Shader** (+2): Visject material graph or HLSL shader
- **Physics Integration** (+1): PhysX colliders, triggers, raycasts
- **Animation Integration** (+2): Anim graph, state machines, blending
- **UI System** (+1): UICanvas/UIControl hierarchy
- **Save/Load** (+2): Serialization of custom game state
- **Third-Party Plugin** (+1): Integration with external plugin
- **Cross-System** (+1 per system): Touches multiple existing systems

## Workflow
1. Read the feature/story description
2. Identify base complexity from code changes needed
3. Apply Flax-specific complexity factors
4. Present estimate with breakdown
5. Flag if estimate > 8 points (should be split)

## Output
- Point estimate with breakdown
- Recommendation to split if too large
