# [System Name] — Game Design Document

## Overview

### What
[Brief description of what this system does]

### Why
[Why does this system exist? What player experience does it create?]

### Pillar Alignment
[Which game pillars does this system serve, and how?]

## Core Mechanics

### Player Verbs
[What does the player DO in this system?]

### Rules
[Step-by-step description of how the system works]

### State Diagram
```
[State] --[trigger]--> [State]
[State] --[trigger]--> [State]
```

### Formulas

#### [Formula Name]
```
result = base_value * multiplier + bonus
```
- `base_value`: [description, type, default, range]
- `multiplier`: [description, type, default, range]
- `bonus`: [description, type, default, range]
- **Example**: base_value=10, multiplier=1.5, bonus=5 → result=20

## Player Experience Goals

- **Feel**: [snappy/weighty/fluid/deliberate/etc.]
- **Emotion**: [What should the player feel?]
- **Mastery**: [How does getting good at this feel?]
- **Feedback**: [What visual/audio/mechanical feedback reinforces the action?]

## Data Model

### Data Structures
```csharp
[Serialize] public float BaseHealth = 100f;
[Serialize] public float DamageMultiplier = 1.0f;
```

### Tunable Parameters

| Parameter | Type | Default | Range | Description |
|-----------|------|---------|-------|-------------|
| [name] | [type] | [default] | [min-max] | [what it controls] |

### Asset Dependencies
- [What assets does this system load?]

## Edge Cases

- **[Condition]**: What happens when [edge case]?
- **[Condition]**: What happens when [boundary]?
- **Frame-rate**: [Any frame-rate sensitive logic?]
- **Save/Load**: [What state persists?]

## Dependencies

### Requires
- [System] — [what it needs from that system]

### Required By
- [System] — [what depends on this]

### Events Published
- `On[EventName](params)` — [when fired, what it means]

### Events Consumed
- `On[EventName]` — [what it does in response]

## Implementation Notes

### Flax-Specific
- [Any Flax Engine specific considerations]
- [Recommended Actor/Script architecture]
- [Performance considerations]

## Success Metrics

- [How we know it's working — specific, measurable]
- [What to playtest]
- [What "good" looks like in numbers]

## Open Questions

- [ ] [Question that needs playtesting to answer]
- [ ] [Deferred design decision]
