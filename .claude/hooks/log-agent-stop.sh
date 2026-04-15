#!/bin/bash
# Hook: log-agent-stop — Log when an agent completes its work
# Trigger: PostToolUse (agent return)

AGENT_NAME="${1:-unknown}"
TIMESTAMP=$(date +%Y-%m-%dT%H:%M:%S)
LOG_DIR="production/session-state"

echo "[$TIMESTAMP] Agent completed: $AGENT_NAME" >> "$LOG_DIR/agent-log.txt"
