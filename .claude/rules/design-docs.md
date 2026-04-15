---
description: "Design document standards — required sections, formula format, edge cases."
globs: "design/gdd/**/*.md"
---

# Design Document Rules

When editing game design documents:

1. **Required sections**: Every system GDD must have: Overview, Core Mechanics, Player Experience Goals, Data Model, Edge Cases, Dependencies, Success Metrics, Open Questions.

2. **Formula format**: All formulas must use clear variable names and include: formula, variable definitions, example calculation, and tuning range.

3. **Edge cases**: Every mechanic must document edge cases — what happens at 0 health? Max level? Empty inventory? Simultaneous inputs?

4. **Pillar alignment**: Every system must state which game pillars it serves and how.

5. **Implementability**: Specs must be detailed enough for a programmer to implement without further clarification. If ambiguous, mark as "Open Question".
