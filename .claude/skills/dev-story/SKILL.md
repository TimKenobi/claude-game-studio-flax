---
name: dev-story
description: "Implement a user story — read the story, propose architecture, implement, test, and mark complete. The primary coding workflow skill."
argument-hint: "[story-id or story file path]"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write, Edit, Bash, Task
---

When this skill is invoked with a story identifier:

## 1. Read the Story

Find and read the story file. Extract:
- Acceptance criteria
- Technical requirements
- Dependencies on other stories
- Owning system/module

## 2. Check Prerequisites

- Are dependency stories complete?
- Does a GDD exist for this system? Read it.
- Does an ADR exist? Follow it.
- Is the module interface defined in the architecture blueprint?

## 3. Propose Implementation

Before writing any code:
- Show proposed file structure
- Show key class/interface design
- Explain approach and trade-offs
- Ask: "Does this match your expectations?"

## 4. Implement

Using Flax Engine C# patterns:
- Create Scripts deriving from `Script` for component behavior
- Use `[Serialize]` for editor-tunable values
- Follow coding standards from `.claude/docs/coding-standards.md`
- Write in `GameProject/Source/Game/[Module]/`
- Use delta time for all time-dependent logic
- Emit events for cross-system communication

For each file:
- Ask: "May I write this to [filepath]?"
- Wait for approval

## 5. Write Tests

- Unit tests for logic in `tests/unit/`
- Integration tests if cross-system in `tests/integration/`

## 6. Self-Review

Run through checklist:
- [ ] Follows coding standards
- [ ] No hardcoded values
- [ ] Uses delta time appropriately
- [ ] Events instead of direct coupling
- [ ] Null checks on Actor references
- [ ] Assets cached in OnStart()
- [ ] Tests written and passing

## 7. Mark Complete

Update the story status and run `/story-done [story-id]`.

Verdict: **COMPLETE** — story implemented and tested.
