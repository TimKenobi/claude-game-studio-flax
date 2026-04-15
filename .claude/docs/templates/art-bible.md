# Art Bible: {Game Name}

**Version**: {date}
**Art Director**: {agent/person}

---

## 1. Visual Pillars
{3-5 phrases that define the game's visual identity}

1. **{Pillar 1}** — {Description}
2. **{Pillar 2}** — {Description}
3. **{Pillar 3}** — {Description}

## 2. Reference Board
{Describe visual references from games, films, art, and nature}

### Games
- {Game 1}: {What to reference from it}

### Films / Shows
- {Film 1}: {What to reference from it}

### Art / Artists
- {Artist 1}: {What to reference}

## 3. Color Palette

### Primary Palette
| Name | Hex | Usage |
|------|-----|-------|
| {color} | #{hex} | {where used} |

### Environment-Specific Palettes
| Environment | Dominant | Accent | Mood |
|-------------|----------|--------|------|
| {area} | {color} | {color} | {mood} |

## 4. Lighting Philosophy
- **Key Light**: {direction, color, intensity}
- **Ambient**: {color, intensity}
- **Time of Day**: {fixed / dynamic}
- **Shadow Style**: {hard / soft, color}
- **Mood Goal**: {lighting emotional target}

### Flax Lighting Setup
- Primary: {Directional / Point / Spot Light}
- Sky: {Sky Light / Environment Probe}
- Post-Processing: {Bloom, Color Grading settings}

## 5. Material Standards

### PBR Guidelines
| Parameter | Range | Notes |
|-----------|-------|-------|
| Base Color | {range} | {notes} |
| Roughness | {range} | {notes} |
| Metallic | {range} | {notes} |
| Normal | {range} | {notes} |

### Texture Resolutions
| Asset Type | Resolution | Format |
|------------|------------|--------|
| Characters | {size} | {format} |
| Props | {size} | {format} |
| Environment | {size} | {format} |
| UI | {size} | {format} |

### Flax Material Conventions
- Material naming: `M_{Category}_{Name}` (PascalCase)
- Material instances for variations
- Shared material functions for common effects

## 6. Character Art Specs
- **Poly Budget**: {polycount per LOD}
- **Texture Size**: {resolution}
- **Skeleton**: {bone count, naming}
- **Animation Standards**: {frame rate, naming}

## 7. Environment Art Specs
- **Modular Kit Grid**: {unit size}
- **LOD Levels**: {distances and poly reduction}
- **Foliage**: {approach — billboards, alpha cards, geometry}
- **Terrain**: {Flax terrain settings}

## 8. VFX Style
- **Particle Style**: {stylized / realistic}
- **Post-Processing**: {which effects, intensity ranges}
- **Screen Effects**: {damage, healing, magic}

## 9. UI Visual Language
- **Font Family**: {name}
- **Button Style**: {description}
- **Panel Style**: {description}
- **Icon Style**: {description}
- **Color Usage**: {which colors for what states}

## 10. Technical Constraints
- **Max Draw Calls**: {target per frame}
- **Texture Memory Budget**: {MB}
- **Shader Complexity**: {max instructions}
- **Max Lights Per Scene**: {count}
- **Target Resolution**: {width x height}
