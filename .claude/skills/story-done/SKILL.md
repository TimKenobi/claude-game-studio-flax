---
name: story-done
description: "Mark a story as done after verifying all acceptance criteria, running tests, and confirming code quality."
argument-hint: "<story number>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Story Done Skill

## Purpose
Verify that a story meets its Definition of Done before marking it complete.

## Definition of Done
A story is DONE when ALL of these are true:
1. All acceptance criteria pass
2. Code compiles without errors or warnings
3. No `TODO(urgent)` or `FIXME` comments in new code
4. Code follows `.claude/rules/` for its file path
5. Unit tests pass (if applicable)
6. No obvious performance regressions
7. Story document updated with status: Done

## Workflow

### Step 1: Read Story
- Read `production/stories/STORY-{NNN}-*.md`
- Identify all acceptance criteria
- Note implementation files and test requirements

### Step 2: Verify Acceptance Criteria
For each criterion:
- Read the relevant code
- Check that the criterion is met
- Mark pass/fail

### Step 3: Code Quality Check
- Check for magic numbers
- Check for proper error handling
- Verify Flax patterns (Script lifecycle, delta time, etc.)
- Check naming conventions (PascalCase public, _camelCase private)

### Step 4: Update Story
If all criteria pass:
```markdown
**Status**: Done
**Completed**: {date}
**Verified By**: {agent}
```

If criteria fail:
```markdown
**Status**: In Progress
**Blocked By**: {list of failing criteria}
```

### Step 5: Update Sprint
If story is part of a sprint, update sprint tracking in `production/sprints/`.

## Output
- Updated story document with status
- List of any issues found
