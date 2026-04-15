# Directory Structure

```
CLAUDE.md                           # Master configuration
.claude/
  settings.json                     # Hooks, permissions, safety rules
  agents/                           # Agent definitions (markdown + YAML frontmatter)
  skills/                           # Slash commands (subdirectory per skill)
  hooks/                            # Hook scripts (bash, cross-platform)
  rules/                            # Path-scoped coding standards
  docs/
    technical-preferences.md        # Engine-specific coding standards
    coordination-rules.md           # Agent coordination protocol
    coding-standards.md             # Flax C#/C++ coding standards
    context-management.md           # Context window management
    director-gates.md               # Director review gate definitions
    directory-structure.md          # This file
    templates/                      # Document templates

# Flax Engine Source (existing)
Source/
  Editor/                           # Flax Editor source (C#/C++)
  Engine/                           # Flax Engine source (C#/C++)
  Shaders/                          # HLSL shader source
  Platforms/                        # Platform-specific code
  ThirdParty/                       # Third-party libraries
  Tools/                            # Build and pipeline tools

Content/
  Editor/                           # Editor assets
  Engine/                           # Engine default assets
  Shaders/                          # Shader assets

# Game Project Structure
GameProject/
  Content/                          # Game-specific assets
    Scenes/                         # Scene files (.scene)
    Prefabs/                        # Prefab files (.prefab)
    Materials/                      # Material assets (.flax)
    Textures/                       # Texture assets
    Models/                         # 3D model assets
    Audio/                          # Sound and music assets
    UI/                             # UI assets and layouts
    Animations/                     # Animation assets
    VFX/                            # Visual effects
    Data/                           # Data tables and configs
  Source/
    Game/                           # C# gameplay scripts
      Core/                         # Core systems (GameManager, ServiceLocator)
      Player/                       # Player controller, camera, input
      Combat/                       # Combat system, weapons, abilities
      AI/                           # Enemy AI, behavior trees
      UI/                           # HUD, menus, dialogs
      World/                        # Level management, environment
      Narrative/                    # Dialog, cutscenes, quest system
      Audio/                        # Audio manager, sound system
      VFX/                          # Visual effects controllers
      Utility/                      # Helpers, extensions, pooling

# Studio Structure (CCGS-adapted)
design/
  gdd/                              # Game design documents
    game-concept.md                 # High-level concept
    game-pillars.md                 # Design pillars
    systems/                        # Per-system GDDs
  narrative/                        # Story, dialog, lore docs
  levels/                           # Level design documents
  art/                              # Art bible, asset specs

docs/
  architecture/                     # Architecture Decision Records (ADRs)
  engine-reference/
    flax/                           # Flax version reference
  COLLABORATIVE-DESIGN-PRINCIPLE.md

tests/
  unit/                             # Unit tests
  integration/                      # Integration tests
  performance/                      # Performance benchmarks
  playtest/                         # Playtest reports

tools/                              # Build and pipeline tools
prototypes/                         # Throwaway prototypes
production/
  sprints/                          # Sprint plans
  milestones/                       # Milestone tracking
  session-state/                    # Session context preservation
```
