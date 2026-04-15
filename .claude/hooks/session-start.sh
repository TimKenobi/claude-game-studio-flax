#!/bin/bash
# session-start.sh — Shows current branch and recent commits for orientation

echo "=== Session Start ==="
echo "Branch: $(git branch --show-current 2>/dev/null || echo 'not a git repo')"
echo ""
echo "Recent commits:"
git log --oneline -5 2>/dev/null || echo "No git history yet"
echo ""

# Check for active session state
if [ -f "production/session-state/active.md" ]; then
  echo "Active session state found — read production/session-state/active.md to resume."
fi

echo "=== Ready ==="
exit 0
