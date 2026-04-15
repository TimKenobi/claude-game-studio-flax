---
name: map-systems
description: "Decompose the game concept into individual systems, map their dependencies, assign priorities, and create the systems index."
argument-hint: "[no arguments]"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write, Task
---

When this skill is invoked:

## 1. Read the Game Concept

Read `design/gdd/game-concept.md`. If it doesn't exist, tell the user to run `/brainstorm` first.

## 2. Extract Systems

From the game concept, identify all discrete game systems. For a 3D linear fantasy game, typical systems include:

**Core Systems** (required for MVP):
- Player Movement & Camera
- Combat System
- Health & Damage
- Enemy AI
- Level Progression

**Support Systems**:
- Inventory & Equipment
- Abilities / Magic
- Save/Load
- UI / HUD
- Dialog System
- Audio System

**Enhancement Systems**:
- Crafting
- Environmental Interactions
- Collectibles / Achievements
- Difficulty Settings
- Accessibility Options

## 3. Map Dependencies

Create a dependency graph showing which systems depend on which:

```
Player Movement → Combat → Health & Damage
                ↗ Enemy AI
Level Progression → Save/Load
Dialog System → UI / HUD
Inventory → Combat (equipment bonuses)
Abilities → Combat (ability damage) → UI (cooldown display)
```

## 4. Assign Priorities

**P0 (MVP)**: Must have for core loop test
**P1 (Alpha)**: Must have for playable build
**P2 (Beta)**: Should have for complete experience
**P3 (Polish)**: Nice to have

## 5. Create Systems Index

Write to `design/gdd/systems-index.md`:
- System name, priority, dependencies, owning designer
- Status: Not Started / In Design / Designed / Implemented / Tested

## 6. Suggest Next Steps

- `/design-system [highest-priority-system]` — start with the most critical system
- Usually: Player Movement → Combat → Health → Enemy AI → Level Progression

Verdict: **COMPLETE** — systems mapped and indexed.
