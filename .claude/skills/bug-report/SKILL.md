---
name: bug-report
description: "File a structured bug report with reproduction steps, expected vs actual behavior, and severity classification."
argument-hint: "<brief bug description>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Bug Report Skill

## Purpose
Create structured bug reports that enable fast diagnosis and resolution.

## Workflow

### Step 1: Gather Information
- Ask for or determine: What happened? What was expected? When did it start?
- Check related source code for obvious causes
- Check if similar bugs exist in `production/bugs/`

### Step 2: Classify Severity
- **Blocker**: Game crashes, data loss, cannot proceed
- **Critical**: Core feature broken, no workaround
- **Major**: Feature impaired, workaround exists
- **Minor**: Visual glitch, non-blocking issue
- **Trivial**: Cosmetic, polish item

### Step 3: Write Bug Report
Create `production/bugs/BUG-{NNN}-{slug}.md`:

```markdown
# BUG-{NNN}: {Title}
**Severity**: Blocker | Critical | Major | Minor | Trivial
**Priority**: P0 | P1 | P2 | P3
**Status**: Open | In Progress | Fixed | Verified | Won't Fix
**Found In**: {scene, system, or feature}
**Related Stories**: STORY-{NNN}
**Assignee**: {agent or unassigned}

## Description
{Clear description of the bug}

## Steps to Reproduce
1. {Step 1}
2. {Step 2}
3. {Step 3}

## Expected Behavior
{What should happen}

## Actual Behavior
{What actually happens}

## Environment
- Flax Engine 1.11 (Build 6810)
- Platform: {Windows/Linux/Mac}
- Scene: {scene name if applicable}

## Root Cause Analysis
{Suspected or confirmed root cause}

## Fix
{Description of fix applied, or empty if not yet fixed}
```

### Step 4: Update Bug Index
Add entry to `production/bugs/index.md` with severity, status, and link.

## Output
- `production/bugs/BUG-{NNN}-{slug}.md`
- Updated `production/bugs/index.md`
