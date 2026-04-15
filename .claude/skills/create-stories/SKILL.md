---
name: create-stories
description: "Break down an epic into implementable user stories with acceptance criteria, estimates, and Flax-specific implementation notes."
argument-hint: "<epic name or number>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Create Stories Skill

## Purpose
Decompose an epic into small, implementable user stories that a single developer can complete in one session (1-4 hours).

## Workflow

### Step 1: Read Epic
- Read the target epic from `production/epics/EPIC-{NNN}-*.md`
- Read the linked system GDD from `design/gdd/systems/`
- Read architecture docs from `docs/architecture/`
- Identify all features and acceptance criteria

### Step 2: Decompose into Stories
Break features into vertical slices. Each story should:
- Deliver a testable piece of functionality
- Be completable in 1-4 hours
- Have clear acceptance criteria
- Follow the INVEST pattern (Independent, Negotiable, Valuable, Estimable, Small, Testable)

### Step 3: Write Story Documents
For each story, create `production/stories/STORY-{NNN}-{slug}.md`:

```markdown
# STORY-{NNN}: {Title}
**Epic**: EPIC-{NNN}
**Priority**: P0 | P1 | P2 | P3
**Points**: 1 | 2 | 3 | 5 | 8
**Status**: Backlog | Ready | In Progress | Review | Done

## User Story
As a {player/developer}, I want {capability} so that {benefit}.

## Acceptance Criteria
- [ ] {Given/When/Then criterion 1}
- [ ] {Given/When/Then criterion 2}
- [ ] {Given/When/Then criterion 3}

## Implementation Notes
**Flax Scripts**: {scripts to create/modify}
**Scenes**: {scenes affected}
**Assets**: {assets needed}
**Dependencies**: {other stories, systems}

## Technical Approach
{Brief description of implementation strategy using Flax patterns}

## Test Plan
- {How to verify this story works}
```

### Step 4: Estimate Points
- 1 point: < 1 hour, trivial change
- 2 points: 1-2 hours, straightforward
- 3 points: 2-3 hours, some complexity
- 5 points: 3-4 hours, significant work
- 8 points: 4+ hours, should probably be split further

### Step 5: Update Epic
- Add story references to the parent epic
- Update story count and estimated total points

## Output
- `production/stories/STORY-{NNN}-{slug}.md` for each story
- Updated parent epic with story links
