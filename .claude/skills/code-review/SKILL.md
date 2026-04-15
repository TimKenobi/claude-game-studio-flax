---
name: code-review
description: "Review code for quality, patterns, performance, and adherence to architecture and coding standards."
argument-hint: "[file-path or system-name]"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write, Task
---

When this skill is invoked:

## 1. Gather Code

If file path: read that file.
If system name: glob all files in `GameProject/Source/Game/[system]/**/*.cs`.

## 2. Review Checklist

### Architecture
- [ ] Follows dependency direction (no upward references)
- [ ] Uses interfaces for cross-module communication
- [ ] Events for decoupled communication

### Flax Best Practices
- [ ] Scripts derive from `Script` correctly
- [ ] `[Serialize]` for editor-exposed fields
- [ ] Lifecycle methods used correctly (OnEnable, OnUpdate, OnFixedUpdate)
- [ ] Delta time used for time-dependent logic
- [ ] Actor references null-checked
- [ ] Assets cached in OnStart(), not loaded per-frame

### Code Quality
- [ ] No hardcoded magic numbers
- [ ] State machines have explicit transitions
- [ ] Error handling present
- [ ] XML documentation on public APIs

### Performance
- [ ] No allocations in update loops
- [ ] Object pooling where appropriate
- [ ] Physics operations in OnFixedUpdate()
- [ ] Asset loading cached

### Security
- [ ] No sensitive data in serialized fields
- [ ] Input validation at system boundaries
- [ ] Save data validated on load

## 3. Report

Present findings as:
- **Critical** (must fix before merge)
- **Important** (should fix)
- **Suggestion** (nice to have)
- **Positive** (good patterns worth noting)

Verdict: **COMPLETE** — code reviewed.
