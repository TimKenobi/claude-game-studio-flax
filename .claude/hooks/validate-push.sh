#!/bin/bash
# validate-push.sh — Pre-push validation hook
# Warns on pushes to protected branches
# Exits early if the command is not a git push

INPUT="$1"

# Exit early if not a git push
if ! echo "$INPUT" | grep -qE 'git push'; then
  exit 0
fi

# Check for force push
if echo "$INPUT" | grep -qE '\-\-force|\-f'; then
  echo "BLOCKED: Force push detected. This requires explicit user approval."
  exit 1
fi

# Check for push to main/master
if echo "$INPUT" | grep -qE '(main|master)'; then
  echo "WARNING: Pushing directly to main/master. Consider using a feature branch."
fi

exit 0
