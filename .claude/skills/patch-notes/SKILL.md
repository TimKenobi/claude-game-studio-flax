---
name: patch-notes
description: "Generate player-facing patch notes from the changelog, written in an engaging style appropriate for the game's tone."
argument-hint: "<version number>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Patch Notes Skill

## Purpose
Transform technical changelog entries into player-friendly patch notes with an engaging tone that matches the game's fantasy setting.

## Workflow

### Step 1: Read Changelog
- Read `CHANGELOG.md` for the target version
- Identify player-visible changes (skip purely technical items)

### Step 2: Write Patch Notes
Create `production/releases/{version}/patch-notes.md`:

```markdown
# {Game Name} — Patch {version}
*{date}*

## New Adventures
{New features described in thematic, engaging language}

## Improved Journeys
{Changes and improvements}

## Vanquished Bugs
{Bug fixes described with humor or flavor}

## Behind the Curtain
{Technical improvements that affect player experience indirectly}
```

### Step 3: Review Tone
- Match the game's fantasy setting
- Keep it concise but flavorful
- Avoid technical jargon
- Highlight what players will notice most

## Output
- `production/releases/{version}/patch-notes.md`
