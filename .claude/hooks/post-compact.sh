#!/bin/bash
# Hook: post-compact — Restore context awareness after compaction
# Trigger: After context window compaction

echo "Context compacted. Key files to re-read:"
echo "  - CLAUDE.md (master config)"
echo "  - production/session-state/active.md (current state)"
echo "  - .claude/docs/technical-preferences.md (constraints)"
