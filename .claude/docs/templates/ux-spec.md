# UX Specification: {Feature Name}

**System**: {related system}
**Priority**: {P0-P3}
**Date**: {YYYY-MM-DD}

## Player Journey

### Trigger
{How does the player initiate this interaction?}

### Flow
1. {Step 1 — what happens}
2. {Step 2 — what happens}
3. {Step 3 — what happens}

### Resolution
{How does the flow end? What state is the player in after?}

## Screen Layouts

### {Screen Name}
```
┌─────────────────────────────────┐
│  {Header}                       │
├─────────────────────────────────┤
│                                 │
│  {Main Content Area}            │
│                                 │
├─────────────────────────────────┤
│  {Action Buttons}               │
└─────────────────────────────────┘
```

**Elements**:
| Element | Type | Behavior |
|---------|------|----------|
| {name} | Button/Label/Image | {interaction} |

## Flax UI Implementation

### UICanvas Configuration
- **Render Mode**: {ScreenSpace / WorldSpace / CameraSpace}
- **Render Order**: {number}

### Control Hierarchy
```
UICanvas
  └── Panel (root)
      ├── Header (ContainerControl)
      │   └── TitleLabel (Label)
      ├── Content (ContainerControl)
      │   └── ...
      └── Actions (HorizontalPanel)
          ├── ButtonA (Button)
          └── ButtonB (Button)
```

## Input Handling
| Input | Action |
|-------|--------|
| Mouse Click | {action} |
| Escape | {action} |
| Gamepad B | {action} |

## Transitions & Animation
- **Open**: {animation description}
- **Close**: {animation description}
- **Between screens**: {transition type}

## Accessibility
- Minimum font size: {px}
- Contrast ratio: {minimum}
- Gamepad navigation: {yes/no}
- Colorblind considerations: {notes}

## Audio
- **On Open**: {sound effect}
- **On Button Press**: {sound effect}
- **On Close**: {sound effect}
