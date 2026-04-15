---
name: help
description: "Show all available skills organized by workflow phase, plus the recommended workflow for the current project state."
argument-hint: "[no arguments]"
user-invocable: true
allowed-tools: Read, Glob
---

# Available Skills — Flax Engine Game Studio

## Workflow Phases

### 1. Onboarding & Navigation
- `/start` — First-time onboarding, project state detection
- `/help` — This help screen

### 2. Game Concept & Design
- `/brainstorm` — Guided game concept ideation
- `/map-systems` — Decompose concept into systems with dependencies
- `/design-system [name]` — Author a detailed GDD for one system
- `/art-bible` — Create visual identity specification
- `/quick-design [topic]` — Quick informal design note

### 3. Architecture
- `/create-architecture` — Master architecture blueprint
- `/architecture-decision [topic]` — Record an Architecture Decision Record

### 4. Implementation
- `/dev-story [id]` — Implement a user story end-to-end
- `/prototype [mechanic]` — Build a throwaway prototype
- `/create-epics` — Map systems to epics
- `/create-stories` — Break epics into stories

### 5. Sprint Management
- `/sprint-plan [new|N]` — Plan or review sprints
- `/sprint-status` — Current sprint progress

### 6. Quality & Review
- `/code-review [path]` — Review code quality
- `/design-review [path]` — Review design doc completeness
- `/architecture-review [system]` — Review codebase architecture
- `/gate-check [phase]` — Phase gate validation
- `/qa-plan [system]` — Create test plan for a system
- `/smoke-check [area]` — Quick smoke test checklist
- `/story-readiness [id]` — Check story is ready for implementation
- `/story-done [id]` — Verify story meets Definition of Done

### 7. Production & Tracking
- `/bug-report [description]` — File a structured bug report
- `/bug-triage` — Triage and prioritize open bugs
- `/sprint-status [N]` — Current sprint progress
- `/milestone-review [N]` — Review milestone progress
- `/retrospective [N]` — Sprint/milestone retrospective
- `/estimate [feature]` — Estimate effort for a feature

### 8. Performance & Technical Health
- `/perf-profile [system]` — Profile and optimize performance
- `/tech-debt [system]` — Catalog and prioritize technical debt

### 9. Release
- `/release-checklist [version]` — Pre-release validation checklist
- `/changelog [version]` — Generate changelog from completed work
- `/patch-notes [version]` — Player-facing patch notes

### 10. UX
- `/ux-design [feature]` — Design UX flows and wireframes

## Recommended Flow for 3D Linear Fantasy (Flax Engine)

```
/start → /brainstorm → /art-bible → /map-systems
    → /design-system (×N) → /design-review → /create-architecture
    → /architecture-decision (×N) → /gate-check TD-FEASIBILITY
    → /prototype → /create-epics → /create-stories
    → /sprint-plan → /story-readiness → /dev-story (×N)
    → /code-review → /story-done → /smoke-check
    → /sprint-status → /perf-profile → /milestone-review
    → /retrospective → /release-checklist → /changelog
```

## Quick Reference: 26 Skills Total
| Phase | Skills |
|-------|--------|
| Start | start, help |
| Design | brainstorm, map-systems, design-system, art-bible, quick-design, ux-design |
| Architecture | create-architecture, architecture-decision, architecture-review |
| Implementation | dev-story, prototype, create-epics, create-stories, estimate |
| Sprint | sprint-plan, sprint-status |
| Quality | code-review, design-review, gate-check, qa-plan, smoke-check, story-readiness, story-done |
| Production | bug-report, bug-triage, milestone-review, retrospective |
| Performance | perf-profile, tech-debt |
| Release | release-checklist, changelog, patch-notes |
