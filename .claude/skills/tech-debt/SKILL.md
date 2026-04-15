---
name: tech-debt
description: "Catalog and prioritize technical debt items, suggest refactoring plans, and create stories for debt reduction."
argument-hint: "[system name or 'audit']"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Technical Debt Skill

## Purpose
Identify, catalog, and plan resolution of technical debt in the codebase.

## Workflow

### Step 1: Audit Code
If `audit` is specified, scan all `GameProject/Source/Game/` code. Otherwise, focus on the named system.

Look for:
- `TODO` and `FIXME` comments
- Magic numbers
- Duplicated code blocks
- God classes (>300 lines or >5 responsibilities)
- Missing error handling
- Tight coupling between systems
- Direct scene/actor references where events should be used
- Allocation patterns in update loops
- Missing null checks on Actor references

### Step 2: Classify Debt
For each item, classify:
- **Type**: Design Debt | Code Debt | Test Debt | Documentation Debt
- **Severity**: High (blocks progress) | Medium (slows progress) | Low (minor friction)
- **Cost to Fix**: Hours estimate
- **Cost to Ignore**: Risk if not fixed

### Step 3: Write Debt Register
Create/update `production/tech-debt/register.md`:

```markdown
# Technical Debt Register

| # | Type | Location | Description | Severity | Fix Cost | Ignore Cost |
|---|------|----------|-------------|----------|----------|-------------|
| TD-1 | Code | {file:line} | {description} | High | 2h | Crashes |
```

### Step 4: Create Reduction Stories
For High severity items, automatically create stories in `production/stories/`.
For Medium, add to backlog.
For Low, note for future sprints.

## Output
- `production/tech-debt/register.md`
- Optional: reduction stories
