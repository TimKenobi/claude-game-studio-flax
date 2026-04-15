# Technical Preferences — Flax Engine

## Engine & Language

- **Engine**: Flax Engine 1.11
- **Primary Language**: C# (.NET 7+)
- **Secondary Language**: C++ (engine-level code, performance-critical systems)
- **Shader Language**: HLSL (via Flax shader pipeline)
- **Visual Scripting**: Visject (Flax visual scripting)
- **Build System**: Flax.Build

## Naming Conventions

### C# (Gameplay Code)
- Classes: PascalCase (e.g., `PlayerController`)
- Public properties/fields: PascalCase (e.g., `MoveSpeed`, `JumpForce`)
- Private fields: _camelCase (e.g., `_currentHealth`, `_isGrounded`)
- Methods: PascalCase (e.g., `TakeDamage()`, `ApplyMovement()`)
- Events/Delegates: PascalCase (e.g., `OnHealthChanged`, `OnDeath`)
- Files: PascalCase matching class (e.g., `PlayerController.cs`)
- Constants: PascalCase or UPPER_SNAKE_CASE (e.g., `MaxHealth`)
- Enums: PascalCase (e.g., `CombatState.Attacking`)

### C++ (Engine Code)
- Classes: Prefixed PascalCase (`A` for Actor derivatives, follows Flax conventions)
- Variables: camelCase for local, PascalCase for members
- Functions: PascalCase (e.g., `Initialize()`, `OnUpdate()`)
- Files: PascalCase matching class (e.g., `PlayerController.h/.cpp`)
- Macros: UPPER_SNAKE_CASE

### Assets
- Scenes: PascalCase (e.g., `ForestLevel.scene`)
- Prefabs: PascalCase (e.g., `EnemyGoblin.prefab`)
- Materials: PascalCase (e.g., `StoneBrick.flax`)
- Textures: PascalCase with suffix (e.g., `StoneBrick_Albedo.png`)
- Models: PascalCase (e.g., `Sword_Iron.fbx`)

## Input & Platform

- **Target Platforms**: PC (Steam)
- **Input Methods**: Keyboard/Mouse, Gamepad
- **Primary Input**: Keyboard/Mouse
- **Gamepad Support**: Full
- **Touch Support**: None
- **Platform Notes**: All UI must support gamepad navigation. Action prompts should adapt to current input device.

## Performance Budgets

- **Target Framerate**: 60fps
- **Frame Budget**: 16.6ms
- **Draw Calls**: < 2000 per frame
- **Triangle Budget**: < 2M per frame
- **Memory Budget**: < 4GB RAM
- **Loading Time**: < 5s per level transition

## Testing

- Framework: Flax built-in test runner + NUnit for C#
- Coverage target: 80%+ for gameplay logic
- Performance tests for combat and AI systems

## Forbidden Patterns

- [TO BE CONFIGURED — add patterns as they emerge]

## Allowed Libraries

- Flax Engine built-in systems
- [Additional libraries added when actively being integrated]

## Engine Specialists

- **Primary**: flax-specialist
- **Language/Code Specialist**: flax-specialist (C# review — primary covers it)
- **Shader Specialist**: flax-specialist (HLSL shaders, Flax material editor)
- **UI Specialist**: ui-programmer (Flax UICanvas, UIControl)
- **Routing Notes**: Invoke primary for architecture and general C#/C++ code review. Route shader questions to flax-specialist.

### File Extension Routing

| File Extension / Type | Specialist to Spawn |
|-----------------------|---------------------|
| Game code (.cs files) | flax-specialist |
| Engine code (.cpp, .h files) | engine-programmer |
| Shader files (.shader, .hlsl) | flax-specialist |
| Material assets (.flax) | technical-artist |
| Scene / prefab files (.scene, .prefab) | flax-specialist |
| UI layouts | ui-programmer |
| General architecture review | flax-specialist |
