#!/bin/bash
# validate-assets.sh — Post-write validation for asset files
# Checks naming conventions and structure
# Exits early if the file is not in GameProject/Content/

INPUT="$1"

# Exit early if not an asset file
if ! echo "$INPUT" | grep -qE 'GameProject/Content/'; then
  exit 0
fi

# Check naming convention (should be PascalCase)
FILENAME=$(basename "$INPUT" | sed 's/\.[^.]*$//')
if echo "$FILENAME" | grep -qE '^[a-z]|[_-]'; then
  echo "WARNING: Asset filename '$FILENAME' should use PascalCase naming."
  echo "Example: 'StoneBrick_Albedo' instead of 'stone_brick_albedo'"
fi

exit 0
