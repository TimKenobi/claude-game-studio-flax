---
name: design-system
description: "Author a detailed Game Design Document (GDD) for a specific game system. Guides through each section interactively, ensuring completeness and implementability."
argument-hint: "[system-name] (e.g., combat, progression, inventory)"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write, Task
---

When this skill is invoked with a system name:

## 1. Context Gathering

- Read `design/gdd/game-concept.md` for pillars and core loop
- Read `design/gdd/game-pillars.md` if it exists
- Check if a GDD already exists for this system in `design/gdd/systems/`
- Read any related GDDs (dependency systems)

## 2. Section-by-Section GDD Writing

Guide the user through each section interactively:

### Section 1: Overview
- What is this system?
- Why does it exist? (What player experience does it create?)
- How does it connect to the core fantasy and pillars?

### Section 2: Core Mechanics
- How does it work step by step?
- What are the player's verbs within this system?
- State diagram if applicable
- Formula definitions with all variables

### Section 3: Player Experience Goals
- What emotion should this system create?
- What's the "feel" — snappy, weighty, fluid, deliberate?
- How does mastery manifest?

### Section 4: Data Model
- What data structures drive this system?
- What's tunable by designers? (List every parameter with type, default, range)
- What's loaded from assets vs. computed at runtime?

### Section 5: Edge Cases
- What happens at boundary conditions?
- Error states and recovery
- Frame-rate dependence considerations (must use delta time)

### Section 6: Dependencies
- What other systems does this rely on?
- What systems rely on this?
- What events does it publish/subscribe to?

### Section 7: Success Metrics
- How do we know this system is working as intended?
- What would we playtest to validate?
- What does "good" look like in numbers?

### Section 8: Open Questions
- What needs playtesting to decide?
- What design decisions are deferred?

## 3. Write the GDD

Write to `design/gdd/systems/[system-name].md`.
Format using the template at `.claude/docs/templates/system-gdd.md`.

## 4. Suggest Next Steps

- `/design-system [next-system]` — author the next system GDD
- `/design-review design/gdd/systems/[system-name].md` — validate completeness
- `/create-architecture` — if all systems are designed

Verdict: **COMPLETE** — system GDD authored.
