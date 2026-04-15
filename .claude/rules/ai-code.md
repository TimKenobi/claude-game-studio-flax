---
description: "AI system code standards — performance budgets, debuggability, data-driven parameters."
globs: "GameProject/Source/Game/AI/**/*.cs"
---

# AI Code Rules

When editing AI code:

1. **Performance budget**: AI update must stay under 2ms per frame. Use AI LOD for distant enemies.

2. **Data-driven**: All AI parameters (detection range, attack cooldowns, behavior weights) must be configurable per-enemy-type via `[Serialize]` fields or data assets.

3. **Debuggability**: Include visual debug drawing (gizmos) for AI state, detection ranges, and pathfinding. Enable via debug flag.

4. **Staggered updates**: Not all AI entities should update every frame. Implement frame staggering.

5. **Navigation**: Use Flax's NavMesh system for pathfinding. Validate paths before following.
