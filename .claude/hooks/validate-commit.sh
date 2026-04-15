#!/bin/bash
# validate-commit.sh — Pre-commit validation hook
# Checks for hardcoded values, TODO format, and common issues
# Exits early if the command is not a git commit

INPUT="$1"

# Exit early if not a git commit
if ! echo "$INPUT" | grep -qE 'git commit'; then
  exit 0
fi

ERRORS=0

# Check for hardcoded magic numbers in gameplay code
if git diff --cached --name-only | grep -qE 'GameProject/Source/Game/.*\.cs$'; then
  MAGIC=$(git diff --cached -- 'GameProject/Source/Game/*.cs' | grep -E '^\+.*[^a-zA-Z_](100|200|500|1000|9999)[^a-zA-Z_0-9]' | grep -vE '(Serialize|Tooltip|const|readonly|enum)' || true)
  if [ -n "$MAGIC" ]; then
    echo "WARNING: Possible hardcoded magic numbers in gameplay code:"
    echo "$MAGIC"
    echo "Consider using [Serialize] fields or data assets."
    ERRORS=$((ERRORS + 1))
  fi
fi

# Check for TODO format (should be: TODO(name): description)
TODOS=$(git diff --cached | grep -E '^\+.*TODO[^(]' || true)
if [ -n "$TODOS" ]; then
  echo "WARNING: TODOs should follow format: TODO(name): description"
  echo "$TODOS"
fi

# Check for Debug.Log left in production code
DEBUGLOGS=$(git diff --cached -- 'GameProject/Source/Game/*.cs' | grep -E '^\+.*Debug\.(Log|Warning|Error)' || true)
if [ -n "$DEBUGLOGS" ]; then
  echo "NOTE: Debug logging found in commit — ensure this is intentional:"
  echo "$DEBUGLOGS"
fi

exit 0
