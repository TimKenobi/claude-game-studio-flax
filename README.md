# Claude Game Studio — Flax Edition

AI-driven game development framework built on [Flax Engine](https://flaxengine.com) 1.11. Forked and adapted from [Claude-Code-Game-Studios](https://github.com/Donchitos/Claude-Code-Game-Studios) with curated resources from [awesome-flax](https://github.com/kacevoid/awesome-flax).

A coordinated multi-agent architecture for building a **3D linear fantasy action-adventure game** using Claude Code as the development team.

## What's Included

| Component | Count | Description |
|-----------|-------|-------------|
| **Agents** | 28 | Specialized AI roles - directors, designers, programmers, artists, QA |
| **Skills** | 26 | Workflow commands from `/start` through `/release-checklist` |
| **Rules** | 8 | Path-scoped coding standards for C#, shaders, tests, design docs |
| **Hooks** | 12 | Automated validation for commits, assets, sessions |
| **Templates** | 10 | GDD, ADR, sprint plan, UX spec, art bible, epic, story, and more |
| **Game Scripts** | 8 | Starter C# scripts - player, camera, combat, audio, pooling |

## Quick Start

```
/start          - Detect project state and get oriented
/brainstorm     - Design your game concept interactively
/help           - See all 26 available skills
```

### Recommended Workflow

```
/start -> /brainstorm -> /art-bible -> /map-systems
    -> /design-system -> /create-architecture -> /gate-check
    -> /create-epics -> /create-stories -> /sprint-plan
    -> /dev-story -> /code-review -> /smoke-check
    -> /milestone-review -> /release-checklist
```

## Project Structure

```
.claude/
  agents/        - 28 AI agent definitions (flax-specialist, gameplay-programmer, etc.)
  skills/        - 26 workflow skills (/brainstorm, /dev-story, /gate-check, etc.)
  rules/         - 8 path-scoped coding standards
  hooks/         - 12 validation and session hooks
  docs/          - Core docs, templates, technical preferences
GameProject/
  Source/Game/    - C# gameplay scripts organized by system
    Core/        - GameManager, EventBus
    Player/      - PlayerController, ThirdPersonCamera
    Combat/      - HealthComponent
    World/       - InteractionSystem
    Audio/       - AudioManager
    Utility/     - ObjectPool
  Content/       - Game assets (scenes, prefabs, materials, etc.)
design/          - Game design documents
production/      - Sprints, epics, stories, bugs, session state
tests/           - Unit and integration tests
prototypes/      - Throwaway mechanic prototypes
```

## Agents

Three-tier hierarchy for organized development:

**Directors** - Creative Director, Technical Director, Producer

**Leads** - Game Designer, Lead Programmer, Art Director, Audio Director, Narrative Director, QA Lead

**Specialists** - Flax Specialist, Gameplay Programmer, Engine Programmer, AI Programmer, UI Programmer, Tools Programmer, Systems Designer, Level Designer, Technical Artist, Writer, World Builder, Sound Designer, UX Designer, Economy Designer, Accessibility Specialist, Performance Analyst, QA Tester, Prototyper, Release Manager

## Starter Scripts

| Script | Purpose |
|--------|---------|
| `GameManager` | Singleton game state management with scene transitions |
| `EventBus` | Decoupled cross-system messaging (publish/subscribe) |
| `PlayerController` | Third-person character movement with sprint and jump |
| `ThirdPersonCamera` | Orbit camera with collision avoidance |
| `HealthComponent` | Reusable damage/heal system for any actor |
| `InteractionSystem` | IInteractable interface with proximity detection |
| `AudioManager` | Music, ambient, SFX, and UI sound management |
| `ObjectPool` | Generic actor pooling to reduce GC pressure |

## Recommended Flax Plugins

From [awesome-flax](https://github.com/kacevoid/awesome-flax):

- **CharacterControllerPro** - Modular character controller
- **SpringArmPlugin** - Camera spring arm (wall clipping prevention)
- **FlaxPrototypeTools** - Level blockout primitives
- **FTween** - Tweening library for animations
- **FlaxObjectPool** - Object pooling for performance
- **Journal** - In-game console with command handling
- **ImGui** - Debug GUI overlay
- **ArizonaFramework** - Ready-to-use game framework
- **FidelityFX-FSR** - AMD upscaling
- **DLSS** - NVIDIA upscaling

## Tech Stack

- **Engine**: Flax Engine 1.11 (Build 6810)
- **Language**: C# (primary), C++ (engine-level)
- **Target**: PC / 60fps / Third-person 3D

## Credits

- [Flax Engine](https://flaxengine.com) - High quality modern 3D game engine
- [Claude-Code-Game-Studios](https://github.com/Donchitos/Claude-Code-Game-Studios) - Original multi-agent game dev framework
- [awesome-flax](https://github.com/kacevoid/awesome-flax) - Curated Flax Engine resources

## License

Game studio framework files (`.claude/`, `GameProject/`, `design/`, `production/`, `	ests/`, `prototypes/`, `	ools/`) are provided as-is for use with Claude Code.

Flax Engine source code is governed by the [Flax Engine EULA](https://flaxengine.com/licensing/).
