---
name: retrospective
description: "Run a sprint or milestone retrospective — what went well, what didn't, and what to improve."
argument-hint: "[sprint/milestone number or 'latest']"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Retrospective Skill

## Purpose
Reflect on a completed sprint or milestone to identify improvements for the next iteration.

## Workflow

### Step 1: Gather Data
- Read sprint/milestone completion data
- Review stories completed, bugs found, blockers encountered
- Check velocity trends if multiple sprints exist

### Step 2: Facilitate Retrospective
Structure around three questions:

**What went well?**
- Things to keep doing
- Successful patterns and approaches

**What didn't go well?**
- Friction points, delays, rework
- Process issues, communication gaps

**What will we change?**
- Specific, actionable improvements
- Assign owners and deadlines

### Step 3: Write Retrospective
Create `production/retrospectives/RETRO-{NNN}-{date}.md`:

```markdown
# Retrospective: Sprint {N} / Milestone {N}
**Date**: {YYYY-MM-DD}
**Velocity**: {points completed}

## What Went Well
- {item}

## What Didn't Go Well
- {item}

## Action Items
| # | Action | Owner | Due |
|---|--------|-------|-----|
| 1 | {action} | {agent} | {date} |

## Process Changes
- {change to adopt going forward}
```

## Output
- Retrospective document
- Action items to track
