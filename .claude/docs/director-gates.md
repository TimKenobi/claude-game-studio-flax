# Director Gates

Director gates are quality checkpoints where Tier 1 (Director) agents review work before it progresses to the next phase. Used by skills that spawn director agents.

## Gate Definitions

### CD-PILLARS (Creative Director)
**Trigger**: After game pillars are defined in `/brainstorm`
**Input**: Full pillar set with design tests, anti-pillars, core fantasy, unique hook
**Pass criteria**: Pillars are distinct, create productive tension, and have clear design tests
**Outcomes**: APPROVED / CONCERNS (with specific feedback) / REJECT (with reasoning)

### AD-CONCEPT-VISUAL (Art Director)
**Trigger**: After game concept is established
**Input**: Elevator pitch, pillar set, target platform, visual references
**Pass criteria**: Visual direction is coherent, feasible, and aligned with pillars
**Outcomes**: 2-3 named visual direction options with pros/cons

### TD-FEASIBILITY (Technical Director)
**Trigger**: After technical risks are identified in `/brainstorm`
**Input**: Core loop, platform target, engine choice, technical risks
**Pass criteria**: No HIGH-risk items without mitigation, engine is appropriate for scope
**Outcomes**: FEASIBLE / CONCERNS (with mitigations) / HIGH RISK (with recommendations)

### PR-SCOPE (Producer)
**Trigger**: After scope tiers are defined
**Input**: Full vision scope, MVP definition, timeline, team size
**Pass criteria**: MVP is achievable in stated timeline, scope tiers are well-defined
**Outcomes**: REALISTIC / UNREALISTIC (with adjustments) / NEEDS DISCUSSION

### TD-ARCHITECTURE (Technical Director)
**Trigger**: After architecture blueprint is created
**Input**: Architecture document, ADR list, system dependency map
**Pass criteria**: No circular dependencies, clear interfaces, appropriate patterns
**Outcomes**: APPROVED / CONCERNS / NEEDS REVISION

### QA-GATE (QA Lead)
**Trigger**: Before phase transitions (pre-production → production, etc.)
**Input**: Phase checklist, test coverage, known issues
**Pass criteria**: All phase requirements met, critical paths tested
**Outcomes**: PASS / CONDITIONAL PASS / FAIL

## Review Mode

Review intensity is controlled by `production/review-mode.txt`:
- **full**: All director gates active at every skill
- **lean**: Directors only at phase gates (`/gate-check`)
- **solo**: No director reviews — maximum speed

Override per-skill with `--review [full|lean|solo]`.
