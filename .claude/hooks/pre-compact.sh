#!/bin/bash
# Hook: pre-compact — Save session state before context compaction
# Trigger: Before context window compaction

STATE_FILE="production/session-state/active.md"

if [ -f "$STATE_FILE" ]; then
    cp "$STATE_FILE" "production/session-state/pre-compact-$(date +%Y%m%d-%H%M%S).md"
    echo "Session state backed up before compaction"
fi
