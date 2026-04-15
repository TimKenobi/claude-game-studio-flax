# Coding Standards — Flax Engine

## C# Standards (Gameplay Code)

### General
- Use `sealed` on classes that won't be inherited
- Prefer composition over inheritance — use Flax's component/script model
- All public API methods must have XML documentation comments
- Use `readonly` for fields that don't change after construction
- Favor `var` for obvious types, explicit types for ambiguous ones

### Flax-Specific C# Patterns
- Scripts derive from `Script` for component behavior
- Use `[Serialize]` attribute for editor-exposed fields
- Use `[ShowInEditor]` for properties without backing serialization
- Use `[Tooltip("...")]` for editor help text
- Override `OnEnable()`, `OnDisable()`, `OnUpdate()`, `OnFixedUpdate()` lifecycle methods
- Use `Actor` references carefully — always null-check, actors can be destroyed
- Prefer `FlaxEngine.Json.JsonSerializer` for data serialization
- Use `Content.Load<T>()` for asset loading with proper null checks
- Use `Level.LoadScene()` / `Level.UnloadScene()` for scene management
- Use `Scripting.InvokeOnUpdate()` for deferred execution

### Data-Driven Values
- All gameplay values (health, damage, speed, cooldowns) MUST come from data assets or config
- Use `[Serialize]` fields with sensible defaults as the minimum
- Prefer Flax Data Assets or JSON configs for tunable values
- Never hardcode magic numbers in gameplay logic

### Event System
- Use C# events (`event Action<T>`) for component-to-component communication
- Use a global EventBus/MessageBus for cross-system events
- Avoid direct references between systems — use events or service locator

### State Machines
- All stateful gameplay systems MUST use explicit state machines
- State transitions must have clear entry/exit/update methods
- Invalid state transitions must be caught and logged

## C++ Standards (Engine Code)

### General
- Follow Flax Engine coding conventions (see Source/.editorconfig)
- Use smart pointers and RAII for resource management
- Zero allocations in hot paths — pre-allocate and pool
- Thread safety must be explicit — document thread-safe vs. main-thread-only
- Profile before and after every optimization

### Memory
- Use object pooling for frequently created/destroyed objects
- Avoid garbage generation in update loops
- Use `Span<T>` and stack allocation where possible in C#

## Asset Standards

### Scenes
- One scene per gameplay area/level
- Scenes must be self-contained — no implicit dependencies on other loaded scenes
- Use prefab instances for reusable objects
- Keep scene hierarchies shallow (< 5 levels deep)

### Prefabs
- Actor compositions that are reused MUST be prefabs
- Prefabs should have a clear root with descriptive name
- Nested prefabs are allowed but keep depth reasonable

### Materials
- Use Flax material instances for variations
- Base materials should be general-purpose; instances for specific looks
- Material parameter names must be descriptive (e.g., `BaseColor`, `Roughness`)
