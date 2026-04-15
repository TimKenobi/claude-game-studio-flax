---
name: gate-check
description: "Run a director gate check to validate work meets quality standards before proceeding to the next phase."
argument-hint: "<gate name: CD-PILLARS | AD-CONCEPT-VISUAL | TD-FEASIBILITY | PR-SCOPE | TD-ARCHITECTURE | QA-GATE>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Gate Check Skill

## Purpose
Validate that work product meets quality standards at defined phase gates before proceeding. Prevents rework by catching issues early.

## Available Gates

### CD-PILLARS — Creative Director Gate
**When**: After brainstorm, before system design
**Validates**:
- [ ] Game concept has 3-5 clear design pillars
- [ ] Pillars are distinct (not overlapping)
- [ ] Every system maps to at least one pillar
- [ ] Target audience is defined
- [ ] Core fantasy/experience is articulated
**Reads**: `design/gdd/game-concept.md`, `design/gdd/game-pillars.md`

### AD-CONCEPT-VISUAL — Art Director Gate
**When**: After concept, before art production
**Validates**:
- [ ] Art bible exists and is complete
- [ ] Visual style aligns with game pillars
- [ ] Color palette is defined
- [ ] Character and environment specs exist
- [ ] Technical constraints documented
**Reads**: `design/art/art-bible.md`

### TD-FEASIBILITY — Technical Director Gate
**When**: After design, before implementation
**Validates**:
- [ ] Systems are within Flax Engine capabilities
- [ ] Performance budget is realistic (60fps target)
- [ ] No conflicting system designs
- [ ] Dependencies are identified
- [ ] Third-party plugins are validated
**Reads**: `design/gdd/systems/`, `docs/architecture/`

### PR-SCOPE — Producer Gate
**When**: After epic creation, before sprint planning
**Validates**:
- [ ] Total scope fits project timeline
- [ ] Dependencies are ordered correctly
- [ ] Critical path identified
- [ ] No scope creep beyond original concept
- [ ] Risk items flagged
**Reads**: `production/epics/index.md`

### TD-ARCHITECTURE — Technical Director Gate
**When**: After architecture design, before heavy coding
**Validates**:
- [ ] Architecture follows SOLID principles
- [ ] Scene/prefab structure is clean
- [ ] C# coding standards defined
- [ ] No God Objects or circular dependencies
- [ ] Performance-sensitive paths identified
**Reads**: `docs/architecture/`, `GameProject/Source/Game/`

### QA-GATE — QA Lead Gate
**When**: Before milestone/release
**Validates**:
- [ ] All P0 stories are Done
- [ ] No critical/blocker bugs open
- [ ] Smoke test passes
- [ ] Performance targets met
- [ ] Build compiles clean
**Reads**: `production/stories/`, `production/bugs/`

## Workflow
1. Determine which gate to run
2. Read review mode from `production/review-mode.txt`
3. Read all relevant documents for that gate
4. Check each validation criterion
5. Report: PASS (all green), WARN (minor issues), FAIL (blockers)
6. If FAIL: list specific items to fix before re-check
7. Log result to `production/gate-log.md`

## Review Mode Behavior
- **full**: Full checklist, detailed feedback, must pass all
- **lean**: Key items only, suggestions are advisory
- **solo**: Automated check only, warnings not blocking
