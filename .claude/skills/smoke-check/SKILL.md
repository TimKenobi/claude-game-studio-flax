---
name: smoke-check
description: "Run a quick smoke test checklist to verify basic game functionality works."
argument-hint: "[area to check or 'full']"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Smoke Check Skill

## Purpose
Quick verification that core functionality hasn't broken. Lighter than a full QA plan — designed for frequent use after changes.

## Standard Smoke Checks

### Build
- [ ] Project compiles without errors (`dotnet build` or Flax Editor build)
- [ ] No new warnings in gameplay code

### Core Systems
- [ ] Game launches to main scene
- [ ] Player controller responds to input
- [ ] Camera follows player correctly
- [ ] Basic UI elements render

### System-Specific (if applicable)
Check based on what was recently changed:
- **Combat**: Can deal and receive damage
- **AI**: Enemies respond to player presence
- **UI**: Menus navigate correctly
- **Audio**: Sound effects play
- **Save/Load**: Save creates file, load restores state

## Workflow
1. Determine scope (full or specific area)
2. Read recent changes (git diff or story log)
3. Check each applicable item by reading relevant code
4. Report pass/fail for each check
5. If failures found, file bug reports via `/bug-report`

## Output
- Smoke check results (displayed inline)
- Bug reports for any failures
