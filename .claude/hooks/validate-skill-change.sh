#!/bin/bash
# Hook: validate-skill-change — Validate changes to skill definitions
# Trigger: PreToolUse (file edit on .claude/skills/)

FILE="${1:-}"

if [[ "$FILE" == *".claude/skills/"* ]]; then
    # Check skill file has required frontmatter
    if [ -f "$FILE" ]; then
        if ! head -1 "$FILE" | grep -q "^---"; then
            echo "WARNING: Skill file missing YAML frontmatter: $FILE"
        fi
        if ! grep -q "^name:" "$FILE"; then
            echo "WARNING: Skill file missing 'name' field: $FILE"
        fi
        if ! grep -q "^description:" "$FILE"; then
            echo "WARNING: Skill file missing 'description' field: $FILE"
        fi
    fi
fi
