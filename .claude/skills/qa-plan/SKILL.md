---
name: qa-plan
description: "Create a QA test plan for a system, feature, or milestone with test cases, smoke tests, and regression checks."
argument-hint: "<system or milestone name>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# QA Plan Skill

## Purpose
Create structured test plans that ensure quality through manual playtest checklists and automated test specifications for Flax Engine gameplay code.

## Workflow

### Step 1: Identify Scope
- Read the target system GDD from `design/gdd/systems/`
- Read implementation stories from `production/stories/`
- Read the relevant source code from `GameProject/Source/Game/`
- Identify all testable behaviors

### Step 2: Define Test Categories
1. **Smoke Tests** — Does it run? Basic functionality
2. **Functional Tests** — Do features work as designed?
3. **Edge Cases** — Boundary conditions, unusual inputs
4. **Integration Tests** — Do systems interact correctly?
5. **Performance Tests** — Within frame budget?
6. **Regression Tests** — Did new changes break old things?

### Step 3: Write Test Plan
Create `tests/{system}/test-plan.md`:

```markdown
# Test Plan: {System Name}
**Version**: {date}
**Related Stories**: STORY-{NNN}, STORY-{NNN}

## Smoke Tests
| # | Test | Steps | Expected | Pass? |
|---|------|-------|----------|-------|
| S1 | {test name} | {how to test} | {expected result} | |

## Functional Tests
| # | Test | Precondition | Steps | Expected | Pass? |
|---|------|-------------|-------|----------|-------|

## Edge Cases
| # | Test | Condition | Expected | Pass? |
|---|------|-----------|----------|-------|

## Integration Tests
| # | Systems | Scenario | Expected | Pass? |
|---|---------|----------|----------|-------|

## Performance Tests
| # | Metric | Target | Measured | Pass? |
|---|--------|--------|----------|-------|

## Automated Tests
{List of C# unit tests to write}
- `{TestClass}.{TestMethod}` — {what it validates}
```

### Step 4: Write Automated Test Specs
For each automated test, specify:
- Test class and method name (following `{System}_{Method}_{ExpectedResult}` naming)
- Arrange/Act/Assert structure
- Flax-specific test setup (scene loading, actor spawning)

### Step 5: Review
- QA Lead reviews completeness
- Developer reviews feasibility
- Add to regression suite

## Output
- `tests/{system}/test-plan.md`
- Test specs ready for implementation in `tests/unit/` or `tests/integration/`
