---
name: sprint-plan
description: "Create or update a sprint plan — organize stories into a time-boxed sprint with priorities and assignments."
argument-hint: "new | [sprint-number]"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write
---

When this skill is invoked:

## If "new":

1. Read `design/gdd/systems-index.md` for system priorities
2. Ask: "How long is this sprint?" (1 week / 2 weeks / custom)
3. Select stories for the sprint based on priority and dependencies
4. Create sprint file: `production/sprints/sprint-[N].md`

## Sprint File Format:

```markdown
# Sprint [N] — [Theme]
**Duration**: [start] to [end]
**Goal**: [One-sentence sprint goal]

## Stories

| ID | Story | System | Priority | Status |
|----|-------|--------|----------|--------|
| S001 | [description] | [system] | P0 | Not Started |
| S002 | [description] | [system] | P0 | Not Started |

## Risks
- [Risk 1]

## Definition of Done
- [ ] All P0 stories implemented
- [ ] Unit tests passing
- [ ] No critical bugs
- [ ] Code reviewed
```

## If sprint number provided:

Read the sprint file and show current status.

Verdict: **COMPLETE** — sprint planned.
