---
name: bug-triage
description: "Triage open bugs — prioritize, assign, identify duplicates, and recommend fix order."
argument-hint: ""
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Bug Triage Skill

## Purpose
Review and prioritize all open bugs, ensuring the most critical issues get addressed first.

## Workflow

### Step 1: Gather Open Bugs
- Read all files in `production/bugs/` with Status: Open
- Sort by severity (Blocker > Critical > Major > Minor > Trivial)

### Step 2: Triage Each Bug
For each bug:
- Verify it's still reproducible
- Check for duplicates
- Confirm severity classification
- Assign priority if not set
- Identify which system/agent should fix it

### Step 3: Generate Triage Report
```markdown
# Bug Triage — {date}

## Summary
| Severity | Count |
|----------|-------|
| Blocker | {n} |
| Critical | {n} |
| Major | {n} |
| Minor | {n} |
| Trivial | {n} |

## Recommended Fix Order
1. BUG-{NNN}: {title} — {reason for priority}
2. BUG-{NNN}: {title}

## Duplicates Found
- BUG-{NNN} duplicates BUG-{NNN}

## Status Changes
- BUG-{NNN}: Upgraded to Critical (affects core gameplay)
```

### Step 4: Update Bugs
- Mark duplicates as Won't Fix with reference
- Update priorities as needed
- Assign to appropriate agents

## Output
- Triage report
- Updated bug documents
