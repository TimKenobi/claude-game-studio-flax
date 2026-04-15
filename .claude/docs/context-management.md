# Context Management

## Context Window Awareness

Claude Code has a finite context window. These rules prevent losing work when context fills up.

### Session State File

Active session progress is stored in `production/session-state/active.md`.
Update this file at major milestones:
- After completing a design document
- After implementing a feature
- After resolving a bug
- Before any `/compact` operation

### Session State Format

```markdown
# Active Session — [date]

## Current Task
[What we're working on]

## Completed This Session
- [x] Item 1
- [x] Item 2

## In Progress
- [ ] Current item

## Key Decisions Made
- Decision 1: [rationale]

## Files Modified
- path/to/file1.cs
- path/to/file2.md

## Next Steps
1. [Next action]
2. [Following action]
```

### Context Checkpoints

At 50% context usage:
- Summarize progress so far
- Update active.md

At 70% context usage:
- Write all in-progress work to files
- Update active.md with full state
- Warn: "Context approaching limit. Progress is saved."

At 85% context usage:
- Stop current work
- Write everything to files
- Recommend starting a fresh session

### Resumption Protocol

When starting a new session after context overflow:
1. Read `production/session-state/active.md`
2. Read the last few git commits for recent changes
3. Resume from the documented state
