---
name: create-epics
description: "Break down the game concept or system designs into development epics — large bodies of work that can be further decomposed into stories."
argument-hint: "[system name or 'all']"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Create Epics Skill

## Purpose
Transform game design documents into actionable development epics that organize work into manageable themes aligned with the game's systems.

## Workflow

### Step 1: Read Design Documents
- Read `design/gdd/game-concept.md` for scope
- Read `design/gdd/systems-index.md` for system list
- Read individual system GDDs from `design/gdd/systems/`
- Identify all major feature areas

### Step 2: Define Epic Categories
Standard epic categories for a 3D linear fantasy game:
1. **Core Gameplay** — Player movement, camera, basic interactions
2. **Combat System** — Weapons, abilities, damage, enemies
3. **AI & Enemies** — Enemy behaviors, encounters, spawning
4. **World & Levels** — Level creation, environment, traversal
5. **Narrative & Dialog** — Story delivery, cutscenes, dialog system
6. **UI & HUD** — Menus, HUD, inventory, settings
7. **Audio & Music** — Sound effects, music, ambient audio
8. **VFX & Polish** — Particle effects, screen effects, juice
9. **Technical Foundation** — Save/load, settings, input, performance
10. **Art Pipeline** — Models, textures, materials, animations

### Step 3: Write Epic Documents
For each epic, create `production/epics/EPIC-{NNN}-{slug}.md`:

```markdown
# EPIC-{NNN}: {Title}
**Priority**: P0 | P1 | P2 | P3
**System**: {linked system from systems-index}
**Estimated Size**: S | M | L | XL
**Dependencies**: {other epics}

## Description
{What this epic delivers to the player experience}

## Acceptance Criteria
- [ ] {criterion 1}
- [ ] {criterion 2}

## Stories (to be created)
- {anticipated story 1}
- {anticipated story 2}

## Flax-Specific Notes
{Relevant Flax APIs, scenes, prefabs, or tools}

## Status: Not Started
```

### Step 4: Prioritize
- Assign priorities based on:
  - P0: Must have for playable vertical slice
  - P1: Core experience, needed for beta
  - P2: Important polish, quality of life
  - P3: Nice to have, stretch goals
- Order by dependencies (foundation first)

### Step 5: Create Epic Index
Update `production/epics/index.md` with table of all epics, priorities, sizes, statuses.

## Output
- `production/epics/EPIC-{NNN}-{slug}.md` for each epic
- `production/epics/index.md` — master epic list
