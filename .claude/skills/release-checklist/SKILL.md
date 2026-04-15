---
name: release-checklist
description: "Generate a pre-release checklist for a build — covers build, quality, performance, content, and platform readiness."
argument-hint: "<release version or milestone>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Release Checklist Skill

## Purpose
Ensure a build is ready for release (internal playtest, demo, or public) with a comprehensive checklist.

## Checklist Template

### Build
- [ ] Clean build succeeds (no errors, no warnings in gameplay code)
- [ ] Correct build configuration (Release/Shipping)
- [ ] All target platforms build
- [ ] Version number set correctly

### Quality
- [ ] All P0 stories are Done and verified
- [ ] No Blocker or Critical bugs open
- [ ] Smoke test passes (`/smoke-check full`)
- [ ] All unit tests pass
- [ ] No regression in existing features

### Performance
- [ ] Meets 60fps target on minimum spec
- [ ] Memory usage within budget (<4GB)
- [ ] No memory leaks detected
- [ ] Load times acceptable

### Content
- [ ] All required scenes/levels are present
- [ ] No placeholder content in release build
- [ ] Audio plays correctly (no missing clips)
- [ ] UI text is final (no "TODO" or lorem ipsum)

### Flax-Specific
- [ ] Content cooking configured correctly
- [ ] Asset references are valid (no missing references)
- [ ] Scenes load without errors
- [ ] Input bindings configured
- [ ] Game settings serialized properly

### Platform
- [ ] Windows build tested
- [ ] Controller input tested (if applicable)
- [ ] Screen resolutions tested
- [ ] Windowed/fullscreen modes work

## Workflow
1. Run through each checklist item
2. Mark pass/fail
3. Any FAIL blocks release
4. Generate report

## Output
- Release checklist with pass/fail status
- Go/No-Go recommendation
