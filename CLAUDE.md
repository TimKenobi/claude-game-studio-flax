# Claude Code Game Studios — Flax Engine Edition
# 3D Linear Fantasy Game — Studio Agent Architecture

Indie game development managed through coordinated Claude Code subagents.
Each agent owns a specific domain, enforcing separation of concerns and quality.

## Technology Stack

- **Engine**: Flax Engine 1.11 (Build 6810)
- **Language**: C# (primary gameplay), C++ (engine-level systems)
- **Build System**: Flax.Build (MSBuild + custom targets)
- **Asset Pipeline**: Flax Content Pipeline (models, textures, materials, scenes, prefabs)
- **Version Control**: Git with trunk-based development
- **IDE**: Visual Studio / VS Code with Flax Tools extension

## Project Structure

@.claude/docs/directory-structure.md

## Engine Version Reference

@docs/engine-reference/flax/VERSION.md

## Technical Preferences

@.claude/docs/technical-preferences.md

## Coordination Rules

@.claude/docs/coordination-rules.md

## Collaboration Protocol

**User-driven collaboration, not autonomous execution.**
Every task follows: **Question -> Options -> Decision -> Draft -> Approval**

- Agents MUST ask "May I write this to [filepath]?" before using Write/Edit tools
- Agents MUST show drafts or summaries before requesting approval
- Multi-file changes require explicit approval for the full changeset
- No commits without user instruction

See `docs/COLLABORATIVE-DESIGN-PRINCIPLE.md` for full protocol and examples.

> **First session?** If the project has no engine configured and no game concept,
> run `/start` to begin the guided onboarding flow.

## Coding Standards

@.claude/docs/coding-standards.md

## Context Management

@.claude/docs/context-management.md

## Game Concept

**Genre**: 3D Linear Fantasy (Action-Adventure)
**Perspective**: Third-person
**Structure**: Linear progression through handcrafted fantasy environments
**Core Experience**: Epic fantasy journey with tight combat and exploration

> Run `/brainstorm` to flesh out the full concept interactively.

## Recommended Flax Plugins (from awesome-flax)

- **CharacterControllerPro** — Modular character controller (PrecisionRender/CharacterControllerPro)
- **SpringArmPlugin** — Camera spring arm to prevent wall clipping (PrecisionRender/SpringArmPlugin)
- **FlaxPrototypeTools** — Level blockout primitives (Swiggies/FlaxPrototypeTools)
- **FTween** — Tweening library for animations (honzapatCZ/FTween)
- **FlaxObjectPool** — Object pooling for performance (DevHrytsan/FlaxObjectPool)
- **Journal** — In-game console with command handling (Crawcik/Journal)
- **ImGui** — Debug GUI overlay (FlaxEngine/ImGui)
- **ArizonaFramework** — Ready-to-use game framework (FlaxEngine/ArizonaFramework)
- **FidelityFX-FSR** — AMD upscaling (FlaxEngine/FidelityFX-FSR)
- **DLSS** — NVIDIA upscaling (FlaxEngine/DLSS)
- **LiteWater** — Simple infinite water (CthulhuBaba/LiteWater)
- **FlaxProcTerrain** — Procedural terrain generation (AlTheSlacker/FlaxProcTerrain)
