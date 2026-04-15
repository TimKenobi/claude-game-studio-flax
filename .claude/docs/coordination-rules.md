# Coordination Rules

## Agent Coordination Model

Agents follow a structured delegation model:

1. **Vertical delegation** — directors delegate to leads, leads delegate to specialists
2. **Horizontal consultation** — same-tier agents can consult each other but can't make binding cross-domain decisions
3. **Conflict resolution** — disagreements escalate up to the shared parent (`creative-director` for design, `technical-director` for technical)
4. **Change propagation** — cross-department changes are coordinated by `producer`
5. **Domain boundaries** — agents don't modify files outside their domain without explicit delegation

## Studio Hierarchy

```
Tier 1 — Directors
  creative-director    technical-director    producer

Tier 2 — Department Leads
  game-designer        lead-programmer       art-director
  audio-director       narrative-director    qa-lead

Tier 3 — Specialists
  gameplay-programmer  engine-programmer     ai-programmer
  ui-programmer        tools-programmer      flax-specialist
  systems-designer     level-designer        economy-designer
  technical-artist     sound-designer        writer
  world-builder        ux-designer           prototyper
  performance-analyst  qa-tester
```

## File Ownership

| Directory | Owning Agent(s) |
|-----------|-----------------|
| `design/gdd/**` | game-designer, systems-designer |
| `design/narrative/**` | writer, narrative-director |
| `design/levels/**` | level-designer, world-builder |
| `design/art/**` | art-director, technical-artist |
| `GameProject/Source/Game/Core/**` | engine-programmer, lead-programmer |
| `GameProject/Source/Game/Player/**` | gameplay-programmer |
| `GameProject/Source/Game/Combat/**` | gameplay-programmer, systems-designer |
| `GameProject/Source/Game/AI/**` | ai-programmer |
| `GameProject/Source/Game/UI/**` | ui-programmer |
| `GameProject/Source/Game/World/**` | level-designer, gameplay-programmer |
| `GameProject/Source/Game/Narrative/**` | writer, gameplay-programmer |
| `GameProject/Source/Game/Audio/**` | sound-designer, gameplay-programmer |
| `tests/**` | qa-tester, qa-lead |
| `docs/architecture/**` | lead-programmer, technical-director |
| `production/**` | producer |

## Escalation Protocol

1. Specialist encounters ambiguity → asks lead
2. Lead encounters cross-domain conflict → asks director
3. Director encounters strategic disagreement → asks user
4. All agents → if unsure, ask the user

## Change Impact Rules

- **Small** (single file, single system): specialist can propose directly
- **Medium** (multiple files, single system): lead reviews first
- **Large** (cross-system, architecture change): director approval required
- **Critical** (engine-level, build system): user approval required
