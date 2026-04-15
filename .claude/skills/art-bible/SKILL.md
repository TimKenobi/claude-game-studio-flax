---
name: art-bible
description: "Create or update the visual art bible defining the game's visual identity, style, palette, and asset specifications for Flax Engine."
argument-hint: "<aspect or section to focus on>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Art Bible Skill

## Purpose
Define the game's visual identity: style references, color palette, material standards, lighting philosophy, character and environment art specs—all tailored to Flax Engine's rendering capabilities.

## Workflow

### Step 1: Assess Current State
- Check if `design/art/art-bible.md` exists
- Read existing design docs: `design/gdd/game-concept.md`, `design/gdd/game-pillars.md`
- Review any existing art assets in `GameProject/Content/`

### Step 2: Gather Direction
If no art bible exists, present visual style options aligned with the fantasy genre:
- **Stylized** — Painterly, Ghibli-inspired, hand-painted textures
- **Realistic** — PBR materials, photorealistic lighting, film grain
- **Hybrid** — Stylized characters in realistic environments (or vice versa)
- **Low-Poly** — Geometric, flat shading, bold colors

For each, note Flax Engine rendering implications:
- Material complexity (shader graph via Visject)
- Post-processing requirements
- Lighting model (forward vs deferred)
- Performance budget impact

### Step 3: Define Art Bible Sections
Create/update `design/art/art-bible.md` with:

1. **Visual Pillars** — 3-5 phrases that define the look
2. **Reference Board** — Describe mood/reference images (games, films, art)
3. **Color Palette** — Primary, secondary, accent, environment-specific palettes
4. **Lighting Philosophy** — Key light direction, ambient mood, time of day
5. **Material Standards** — PBR parameter ranges, texture resolution targets, Flax material conventions
6. **Character Art Specs** — Poly budgets, texture sizes, rigging standards
7. **Environment Art Specs** — Modular kit standards, LOD levels, foliage approach
8. **VFX Style** — Particle conventions, post-processing usage
9. **UI Visual Language** — Font choices, button styles, HUD approach
10. **Technical Constraints** — Draw call budgets, texture memory limits, shader complexity caps

### Step 4: Flax-Specific Guidelines
Include:
- Material Layer naming in Flax (PascalCase, descriptive)
- Texture import settings (compression, mip maps, streaming)
- Model import settings (scale, coordinate system)
- Recommended Flax material templates from `Content/Engine/`
- Post-processing profile standards

### Step 5: Director Review
If review mode is `full` or `lean`:
- Submit to Art Director for visual consistency review
- Submit to Technical Director for performance feasibility

## Output
- `design/art/art-bible.md` — Complete art bible document
- Updated pillars alignment in `design/gdd/game-pillars.md` if needed
