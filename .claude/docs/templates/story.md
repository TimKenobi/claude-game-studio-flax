# STORY-{NNN}: {Title}

**Epic**: EPIC-{NNN}
**Priority**: P0 | P1 | P2 | P3
**Points**: 1 | 2 | 3 | 5 | 8
**Status**: Backlog | Ready | In Progress | Review | Done
**Assignee**: {agent or unassigned}
**Sprint**: {sprint number or Backlog}

## User Story
As a **{player/developer}**, I want **{capability}** so that **{benefit}**.

## Acceptance Criteria
- [ ] **Given** {precondition}, **When** {action}, **Then** {expected result}
- [ ] **Given** {precondition}, **When** {action}, **Then** {expected result}
- [ ] **Given** {precondition}, **When** {action}, **Then** {expected result}

## Implementation Notes

### Flax Scripts
| Script | Path | Action |
|--------|------|--------|
| {ClassName}.cs | `GameProject/Source/Game/{System}/` | Create / Modify |

### Scenes & Prefabs
- {Scene or prefab affected}

### Assets
- {Models, textures, audio needed}

### Dependencies
- {Other stories or systems required}

## Technical Approach
{Brief description of implementation strategy using Flax patterns}

```csharp
// Pseudocode or key API calls
public class ExampleScript : Script
{
    public override void OnStart()
    {
        // Implementation approach
    }
}
```

## Test Plan
- [ ] {How to verify criterion 1}
- [ ] {How to verify criterion 2}
- [ ] {Automated test: TestClass.TestMethod}

## Completed
**Date**: {YYYY-MM-DD}
**Verified By**: {agent}
**Notes**: {any implementation notes}
