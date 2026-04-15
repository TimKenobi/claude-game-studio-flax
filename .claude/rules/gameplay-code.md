---
description: "Gameplay code standards for Flax Engine C# scripts in the game source directory."
globs: "GameProject/Source/Game/**/*.cs"
---

# Gameplay Code Rules

When editing gameplay C# code:

1. **Data-driven values**: All numeric gameplay values (health, damage, speed, cooldowns, ranges) MUST be `[Serialize]` fields with sensible defaults, or loaded from data assets. Never hardcode magic numbers.

2. **Delta time**: All time-dependent logic MUST use `Time.DeltaTime` or `Time.UnscaledDeltaTime`. Frame-rate dependent movement/timing is a critical bug.

3. **No UI references**: Gameplay code must NEVER directly reference UI classes. Use events or interfaces to communicate with UI systems.

4. **State machines**: Any system with more than 2 states MUST use an explicit state machine with documented transition tables.

5. **Flax lifecycle**: Use `OnStart()` for initialization, `OnUpdate()` for logic, `OnFixedUpdate()` for physics. Cache component/actor references in `OnStart()`.

6. **Null safety**: Always null-check `Actor` references and `Content.Load<T>()` results. Actors can be destroyed at any time.

7. **Events over coupling**: Use C# `event` delegates or a message bus for cross-system communication. No direct references between unrelated systems.
