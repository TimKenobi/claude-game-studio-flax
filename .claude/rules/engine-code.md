---
description: "Engine-level code standards for core systems — performance-critical, zero-allocation paths."
globs: "GameProject/Source/Game/Core/**/*.cs"
---

# Engine/Core Code Rules

When editing core system code:

1. **Zero allocation in hot paths**: Pre-allocate collections, use object pooling, reuse buffers. No `new` in update loops.

2. **Thread safety**: Document whether code is main-thread-only or thread-safe. Use `lock` or `Interlocked` when shared.

3. **API stability**: Public interfaces in Core must be stable. Changes require deprecation period and migration guide.

4. **Dependency direction**: Core code must NEVER depend on feature/gameplay code. Dependency flows: Engine → Core → Features → UI.

5. **Documentation**: Every public class and method must have XML documentation comments with usage examples.

6. **Profiling**: Profile before and after every optimization. Document the measurements.
