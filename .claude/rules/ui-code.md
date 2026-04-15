---
description: "UI code standards — no game state ownership, localization-ready, accessibility."
globs: "GameProject/Source/Game/UI/**/*.cs"
---

# UI Code Rules

When editing UI code:

1. **No game state ownership**: UI scripts MUST NOT own or manage game state. They react to events and display data.

2. **Localization-ready**: No hardcoded user-facing strings. All text must go through a localization system or be stored as data.

3. **Accessibility**: All interactive elements must be navigable by gamepad (d-pad). Support text scaling. Consider colorblind modes.

4. **Input agnostic**: UI must respond to both keyboard/mouse and gamepad. Show appropriate input prompts for the active device.

5. **Flax UICanvas**: Use proper anchoring and margins for resolution independence. Test at multiple resolutions.
