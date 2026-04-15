---
name: sprint-status
description: "Generate a sprint status report showing progress on stories, blockers, velocity, and burndown."
argument-hint: "[sprint number or 'current']"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Sprint Status Skill

## Purpose
Generate a status report for the current or specified sprint showing progress, blockers, and velocity.

## Workflow

### Step 1: Read Sprint Data
- Read current sprint from `production/sprints/`
- Read all stories assigned to this sprint from `production/stories/`
- Tally story points by status

### Step 2: Calculate Metrics
- **Completed**: Sum of points for Done stories
- **In Progress**: Sum of points for In Progress stories
- **Remaining**: Sum of points for Ready/Backlog stories
- **Velocity**: Points completed so far
- **Burndown**: Remaining points vs days left

### Step 3: Generate Report
```markdown
# Sprint {N} Status — {date}

## Progress
| Status | Stories | Points |
|--------|---------|--------|
| Done | {n} | {pts} |
| In Progress | {n} | {pts} |
| Ready | {n} | {pts} |
| Blocked | {n} | {pts} |
| **Total** | **{n}** | **{pts}** |

## Completion: {percentage}%

## Blockers
- {blocker 1 — story reference}

## Risks
- {risk 1}

## Highlights
- {completed story 1}
- {completed story 2}
```

## Output
- Sprint status report (displayed and optionally saved to `production/sprints/`)
