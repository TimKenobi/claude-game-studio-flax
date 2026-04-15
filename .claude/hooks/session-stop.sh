#!/bin/bash
# session-stop.sh — Archives session state and records git activity

# Archive active session state if it exists
if [ -f "production/session-state/active.md" ]; then
  TIMESTAMP=$(date +%Y%m%d_%H%M%S)
  mkdir -p "production/session-state/archive"
  cp "production/session-state/active.md" "production/session-state/archive/session-$TIMESTAMP.md"
  echo "Session state archived to production/session-state/archive/session-$TIMESTAMP.md"
fi

echo "=== Session End ==="
exit 0
