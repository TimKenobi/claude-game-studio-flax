---
name: story-readiness
description: "Check if a story is ready for implementation — has enough detail, clear acceptance criteria, and dependencies resolved."
argument-hint: "<story number>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Story Readiness Skill

## Purpose
Verify a story has enough detail and context for implementation. Prevents starting work on under-defined stories.

## Readiness Criteria
- [ ] **User story** statement is clear (As a... I want... So that...)
- [ ] **Acceptance criteria** are specific and testable (minimum 3)
- [ ] **Implementation notes** reference specific Flax scripts/scenes
- [ ] **Dependencies** are resolved (blocking stories are Done)
- [ ] **Technical approach** is sketched
- [ ] **Points** are estimated
- [ ] **Related GDD** exists for the system being implemented

## Workflow

### Step 1: Read Story
- Read `production/stories/STORY-{NNN}-*.md`
- Check all readiness criteria

### Step 2: Check Dependencies
- Verify dependent stories are marked Done
- Verify required architecture decisions are made
- Verify required assets or systems exist

### Step 3: Report
- If READY: Update status to `Ready`, proceed with implementation
- If NOT READY: List missing items, keep status as `Backlog`

## Output
- Updated story status
- List of any gaps to fill
