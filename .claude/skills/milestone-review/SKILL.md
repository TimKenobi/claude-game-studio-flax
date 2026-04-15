---
name: milestone-review
description: "Review progress against a milestone — verify all epics/stories are on track, identify risks, and recommend adjustments."
argument-hint: "<milestone name or number>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Milestone Review Skill

## Purpose
Assess progress toward a milestone, identify risks, celebrate wins, and recommend course corrections.

## Workflow

### Step 1: Read Milestone Definition
- Read `production/milestones/MS-{NNN}-*.md`
- Identify all epics and stories targeted for this milestone
- Read current sprint status

### Step 2: Gather Status
For each epic in the milestone:
- Count stories by status (Done, In Progress, Backlog)
- Calculate completion percentage
- Identify blockers and risks

### Step 3: Generate Milestone Report
Create/update `production/milestones/MS-{NNN}-review-{date}.md`:

```markdown
# Milestone Review: {Name}
**Date**: {YYYY-MM-DD}
**Target Date**: {YYYY-MM-DD}
**Status**: On Track | At Risk | Behind

## Epic Progress
| Epic | Total Stories | Done | In Progress | Remaining | % |
|------|-------------|------|-------------|-----------|---|

## Overall Completion: {percentage}%

## What's Going Well
- {win 1}

## Risks & Blockers
- [{severity}] {risk} — {mitigation}

## Scope Adjustments Recommended
- {cut/defer/add recommendation}

## Next Actions
1. {action}
```

## Output
- Milestone review document
- Scope adjustment recommendations if needed
