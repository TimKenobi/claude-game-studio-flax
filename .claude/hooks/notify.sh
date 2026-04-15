#!/bin/bash
# Hook: notify — Display important notifications to the user
# Trigger: Various — called by other hooks or skills

MESSAGE="${1:-No message}"
LEVEL="${2:-INFO}"
TIMESTAMP=$(date +%Y-%m-%dT%H:%M:%S)

case "$LEVEL" in
    ERROR)   PREFIX="❌" ;;
    WARN)    PREFIX="⚠️" ;;
    SUCCESS) PREFIX="✅" ;;
    *)       PREFIX="ℹ️" ;;
esac

echo "$PREFIX [$TIMESTAMP] $MESSAGE"
