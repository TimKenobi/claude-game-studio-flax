---
name: quick-design
description: "Rapidly sketch a game system design in a lightweight format — faster than full /design-system for early exploration."
argument-hint: "<system name>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Quick Design Skill

## Purpose
Create a lightweight system design sketch when full GDD detail isn't needed yet. Good for early exploration, optional systems, or when you want to validate an idea before committing to a full design.

## Workflow

### Step 1: Context
- Read game concept and pillars if they exist
- Understand where this system fits

### Step 2: Write Quick Design
Create `design/gdd/sketches/{system-name}.md`:

```markdown
# Quick Design: {System Name}

## One-Line Summary
{What this system does in one sentence}

## Player Experience
{How the player interacts with this system — 2-3 sentences}

## Core Mechanic
{The fundamental loop or interaction}

## Key Components
- {Component 1}: {brief description}
- {Component 2}: {brief description}

## Flax Implementation Sketch
- **Scripts**: {key scripts needed}
- **Scenes/Prefabs**: {assets needed}
- **Data**: {data structures or configs}

## Open Questions
- {Question 1}
- {Question 2}

## Estimated Effort
{S / M / L / XL}
```

### Step 3: Optional Promotion
If the quick design looks solid, it can be promoted to a full system GDD via `/design-system {name}`.

## Output
- `design/gdd/sketches/{system-name}.md`
