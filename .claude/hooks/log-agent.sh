#!/bin/bash
# Hook: log-agent — Log agent invocations for session tracking
# Trigger: PostToolUse (agent delegation)

AGENT_NAME="${1:-unknown}"
TIMESTAMP=$(date +%Y-%m-%dT%H:%M:%S)
LOG_DIR="production/session-state"

mkdir -p "$LOG_DIR"

echo "[$TIMESTAMP] Agent invoked: $AGENT_NAME" >> "$LOG_DIR/agent-log.txt"
