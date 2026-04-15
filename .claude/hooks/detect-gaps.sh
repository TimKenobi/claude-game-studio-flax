#!/bin/bash
# detect-gaps.sh — Detects missing project artifacts and suggests next steps

GAPS=""

# Check for game concept
if [ ! -f "design/gdd/game-concept.md" ]; then
  GAPS="$GAPS\n- No game concept found. Run /brainstorm to create one."
fi

# Check for systems index
if [ ! -f "design/gdd/systems-index.md" ]; then
  if [ -f "design/gdd/game-concept.md" ]; then
    GAPS="$GAPS\n- Game concept exists but no systems map. Run /map-systems."
  fi
fi

# Check for architecture
if [ ! -f "docs/architecture/architecture-blueprint.md" ]; then
  if [ -d "design/gdd/systems" ] && [ "$(ls design/gdd/systems/*.md 2>/dev/null | wc -l)" -gt "2" ]; then
    GAPS="$GAPS\n- System GDDs exist but no architecture blueprint. Run /create-architecture."
  fi
fi

# Check for game source code
if [ ! -d "GameProject/Source/Game" ]; then
  GAPS="$GAPS\n- No game source code yet. Game project structure needs to be created."
fi

if [ -n "$GAPS" ]; then
  echo "=== Project Gaps Detected ==="
  echo -e "$GAPS"
  echo ""
fi

exit 0
