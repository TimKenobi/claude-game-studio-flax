---
name: start
description: "First-time onboarding for the Flax Engine fantasy game project — asks where you are, then guides you to the right workflow. Adapted from CCGS for Flax Engine."
argument-hint: "[no arguments]"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write
---

# Guided Onboarding — Flax Engine Edition

This skill is the entry point for new sessions. It does NOT assume you have a game idea, engine experience, or any prior work. It asks first, then routes you to the right workflow.

---

## Phase 1: Detect Project State

Before asking anything, silently gather context:

- **Engine configured?** Read `.claude/docs/technical-preferences.md`. Check if Engine field says Flax Engine 1.11.
- **Game concept exists?** Check for `design/gdd/game-concept.md`.
- **Source code exists?** Glob for `GameProject/Source/**/*.cs`.
- **Prototypes exist?** Check for subdirectories in `prototypes/`.
- **Design docs exist?** Count markdown files in `design/gdd/`.
- **Production artifacts?** Check for files in `production/sprints/` or `production/milestones/`.

---

## Phase 2: Ask Where the User Is

Present options:

- **A) No idea yet** — Want to explore game concepts
- **B) Vague idea** — Have a rough theme/feeling in mind
- **C) Clear concept** — Know the core idea, need to formalize it
- **D) Existing work** — Have design docs, prototypes, or code already

---

## Phase 3: Route Based on Answer

### If A: No idea yet
1. Recommend `/brainstorm open` for guided ideation
2. Show the full workflow path: `/brainstorm` → `/map-systems` → `/design-system` → `/create-architecture` → `/prototype` → `/sprint-plan`

### If B: Vague idea
1. Ask them to share the vague idea
2. Recommend `/brainstorm [their hint]`
3. Show the workflow path

### If C: Clear concept
1. Ask for a one-sentence description
2. Offer two paths: "Formalize first" (`/brainstorm`) or "Jump straight in" (start coding)
3. Note: Engine is already configured as Flax Engine 1.11

### If D: Existing work
1. Share what was found in Phase 1
2. Recommend `/project-stage-detect` for gap inventory
3. If early stage, suggest starting with `/brainstorm` to formalize the concept

---

## Phase 4: Set Review Mode

If `production/review-mode.txt` doesn't exist, ask:
- **Full** — Director reviews at every skill step
- **Lean** — Directors only at phase gates
- **Solo** — No director reviews (maximum speed)

Write choice to `production/review-mode.txt`.

---

## Phase 5: Confirm and Hand Off

Present the recommended next step and confirm. Never auto-run the next skill.

> **Note**: This project uses **Flax Engine 1.11** with C# scripting.
> The engine is already configured — no need to run `/setup-engine`.

Recommended workflow for a 3D Linear Fantasy game:
1. `/brainstorm` — discover/formalize the game concept
2. `/art-bible` — define the fantasy visual identity
3. `/map-systems` — decompose into systems (combat, progression, narrative, etc.)
4. `/design-system [system]` — author GDD per system
5. `/create-architecture` — master architecture blueprint
6. `/prototype [core-mechanic]` — validate the core loop
7. `/sprint-plan new` — plan the first sprint

Verdict: **COMPLETE** — user oriented and handed off to next step.
