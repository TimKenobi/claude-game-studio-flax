---
name: create-architecture
description: "Produce the master architecture blueprint for the game — defines module boundaries, interfaces, dependency rules, and generates the Required ADR list."
argument-hint: "[no arguments]"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write, Task
---

When this skill is invoked:

## 1. Read All System GDDs

Glob `design/gdd/systems/*.md` and read each. If fewer than 3 systems are designed, recommend running `/design-system` first.

## 2. Define Architecture Layers

For a Flax Engine 1.11 C# game:

```
┌─────────────────────────────────────────┐
│              Presentation               │
│  (UI, HUD, Menus, Visual Feedback)      │
├─────────────────────────────────────────┤
│              Game Features              │
│  (Combat, Abilities, Inventory, Dialog) │
├─────────────────────────────────────────┤
│              Core Systems               │
│  (State Machine, Event Bus, Pooling,    │
│   Save System, Audio Manager)           │
├─────────────────────────────────────────┤
│              Engine Interface            │
│  (Flax Script, Actor, Content, Input,   │
│   Physics, Rendering, Audio)            │
└─────────────────────────────────────────┘
```

**Dependency rule**: Each layer can only depend on layers below it. Never upward.

## 3. Define Module Boundaries

For each system from the GDDs:
- Public interface (what other systems can call)
- Events published (what it broadcasts)
- Events consumed (what it listens to)
- Data dependencies (what config/assets it needs)

## 4. Generate Architecture Blueprint

Write to `docs/architecture/architecture-blueprint.md`:
- Layer diagram
- Module catalog with interfaces
- Dependency map
- Data flow diagram
- Required ADR list (architectural decisions that need formal recording)

## 5. Required ADR List

Identify decisions that need `/architecture-decision`:
- State management approach (centralized vs. distributed)
- Event system design (C# events vs. message bus)
- Save system architecture
- Scene management strategy (one scene per level vs. additive)
- Asset loading strategy (sync vs. async, caching policy)
- Input abstraction layer
- AI architecture (behavior trees vs. state machines vs. utility)

## 6. Suggest Next Steps

- `/architecture-decision [topic]` — record each Required ADR
- `/prototype [core-mechanic]` — validate architecture with a prototype
- `/gate-check pre-production` — validate readiness

Verdict: **COMPLETE** — architecture blueprint produced.
