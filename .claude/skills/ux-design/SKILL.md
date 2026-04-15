---
name: ux-design
description: "Design a user experience flow for a game feature — screen layouts, interaction patterns, and player journey mapping."
argument-hint: "<feature or system name>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# UX Design Skill

## Purpose
Design user experience flows for game features, producing wireframes (text-based), interaction specifications, and Flax UI implementation guidance.

## Workflow

### Step 1: Understand Context
- Read the system GDD for the feature
- Identify all player touch-points
- Note the emotional goals (from game pillars)

### Step 2: Map Player Journey
```markdown
## Player Journey: {Feature}
1. {Trigger} — Player initiates by...
2. {Transition} — Screen/UI changes to...
3. {Core Interaction} — Player can...
4. {Feedback} — System responds with...
5. {Resolution} — Flow ends when...
```

### Step 3: Design Screen Layouts
For each screen/state, create ASCII wireframe:
```
┌─────────────────────────────┐
│  Title Bar                  │
├─────────────────────────────┤
│                             │
│  [Content Area]             │
│                             │
├─────────────────────────────┤
│  [Button A]    [Button B]   │
└─────────────────────────────┘
```

### Step 4: Flax UI Specification
For each screen:
- UICanvas settings (render mode, order)
- UIControl hierarchy (parent-child relationships)
- Input handling (keyboard, mouse, gamepad)
- Transition animations
- Font and style references (from art bible)

### Step 5: Interaction Rules
- Button focus/hover/press states
- Navigation order (keyboard/gamepad)
- Accessibility considerations (text size, contrast, colorblind)
- Sound effects on interactions

### Step 6: Write UX Spec
Create `design/ux/{feature-name}.md` with all sections above.

## Output
- `design/ux/{feature-name}.md` — Complete UX specification
