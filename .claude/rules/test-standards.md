---
description: "Test code standards — naming, coverage, fixture patterns."
globs: "tests/**/*.cs"
---

# Test Code Rules

When editing test code:

1. **Naming**: Test methods follow: `[MethodUnderTest]_[Scenario]_[ExpectedResult]` (e.g., `TakeDamage_WhenHealthZero_TriggersDeathEvent`).

2. **Arrange-Act-Assert**: Every test follows AAA pattern with clear sections.

3. **Coverage**: All gameplay logic must have unit tests. Target 80%+ coverage for Core and gameplay systems.

4. **No engine dependency in unit tests**: Unit tests should test logic, not engine systems. Mock or abstract Flax dependencies.

5. **Test data**: Use explicit test data, not random values. Tests must be deterministic.
