---
name: architecture-decision
description: "Create an Architecture Decision Record (ADR) to document a significant technical decision with context, options, and rationale."
argument-hint: "<decision topic>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Architecture Decision Record Skill

## Purpose
Document significant technical decisions in a structured ADR format so the team can understand the *why* behind architectural choices.

## When to Use
- Choosing between architectural approaches
- Selecting plugins or middleware
- Deciding on data formats or communication patterns
- Making irreversible or costly-to-change decisions

## Workflow

### Step 1: Identify Decision
- Clarify what decision needs to be made
- Gather context from existing docs and code
- Read `docs/architecture/` for existing ADRs

### Step 2: Research Options
- List all viable options (minimum 2)
- For each option, analyze:
  - **Pros**: Benefits, alignment with pillars
  - **Cons**: Risks, costs, technical debt
  - **Flax Compatibility**: How well it works with Flax Engine 1.11
  - **Performance Impact**: Estimated impact on frame budget
  - **Maintenance Cost**: Long-term upkeep effort

### Step 3: Write ADR
Create `docs/architecture/ADR-{NNN}-{slug}.md` using template:

```markdown
# ADR-{NNN}: {Title}
**Status**: Proposed | Accepted | Deprecated | Superseded
**Date**: {YYYY-MM-DD}
**Deciders**: {agents or user}

## Context
What is the issue that we're seeing that is motivating this decision?

## Decision Drivers
- {driver 1}
- {driver 2}

## Options Considered
### Option A: {Name}
{Description, pros, cons}

### Option B: {Name}
{Description, pros, cons}

## Decision Outcome
Chosen option: "{option}", because {justification}.

### Consequences
- Good: {positive consequences}
- Bad: {negative consequences}
- Neutral: {trade-offs accepted}

## Flax Implementation Notes
{Specific Flax Engine patterns, APIs, or configurations for this decision}
```

### Step 4: Review
- Present options to user with recommendation
- If review mode full/lean: Technical Director reviews feasibility
- Record final decision

## Output
- `docs/architecture/ADR-{NNN}-{slug}.md`
- Updated architecture docs as needed
