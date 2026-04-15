---
name: changelog
description: "Generate a changelog from completed stories, bug fixes, and improvements since the last release."
argument-hint: "<version number>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Changelog Skill

## Purpose
Generate a structured changelog from completed work.

## Workflow

### Step 1: Determine Scope
- Identify the release version
- Find all stories completed since last changelog entry
- Find all bugs fixed since last entry

### Step 2: Categorize Changes
- **Added**: New features and capabilities
- **Changed**: Modifications to existing features
- **Fixed**: Bug fixes
- **Removed**: Removed features or content
- **Performance**: Optimization improvements
- **Technical**: Internal refactors (not player-visible)

### Step 3: Write Changelog
Prepend to `CHANGELOG.md`:

```markdown
## [{version}] — {YYYY-MM-DD}

### Added
- {feature from STORY-NNN}

### Changed
- {change from STORY-NNN}

### Fixed
- {fix from BUG-NNN}

### Performance
- {optimization}
```

## Output
- Updated `CHANGELOG.md`
