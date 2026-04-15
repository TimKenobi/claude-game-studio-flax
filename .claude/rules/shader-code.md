---
description: "Shader code standards for HLSL shaders in the Flax Engine project."
globs: "**/*.shader,**/*.hlsl,Source/Shaders/**"
---

# Shader Code Rules

When editing shader code:

1. **Performance**: Minimize texture samples in fragment shaders. Use half precision where possible.

2. **Comments**: Complex shader math must have comments explaining the algorithm.

3. **Naming**: Follow Flax shader naming conventions. Uniforms use descriptive names.

4. **Variants**: Minimize shader variants — each variant is a separate compilation. Use dynamic branching when appropriate.
