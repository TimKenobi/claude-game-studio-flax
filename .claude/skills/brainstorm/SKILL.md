---
name: brainstorm
description: "Guided game concept ideation — from zero idea to a structured game concept document. Uses professional studio techniques, player psychology frameworks, and structured creative exploration. Adapted for Flax Engine 3D fantasy games."
argument-hint: "[genre or theme hint, or 'open'] [--review full|lean|solo]"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write, Task
---

When this skill is invoked:

1. **Parse the argument** for an optional genre/theme hint. If `open` or no argument, start from scratch.
2. **Check for existing concept work**: Read `design/gdd/game-concept.md` if it exists.
3. **Run through ideation phases** interactively.

---

### Phase 1: Creative Discovery

**Emotional anchors**:
- What's a moment in a game that genuinely moved you, thrilled you, or made you lose track of time?
- Is there a fantasy or power trip you've always wanted in a game?

**Taste profile**:
- What 3 games have you spent the most time with? What kept you coming back?
- Genres you love vs. avoid?
- Prefer challenge, relaxation, story, or expression?

**Practical constraints**:
- Timeline: Weeks / Months / 1-2 years / Multi-year
- Dev level: First game / Shipped before / Professional
- Team size: Solo / Small team

Synthesize into a **Creative Brief** (3-5 sentences).

---

### Phase 2: Concept Generation

Generate **3 distinct concepts** for a 3D linear fantasy game:

**Technique 1: Verb-First Design** — Start with the core player verb
**Technique 2: Mashup Method** — Combine two unexpected fantasy elements
**Technique 3: Experience-First Design (MDA Backward)** — Start from desired emotion

For each concept:
- **Working Title**
- **Elevator Pitch** (1-2 sentences)
- **Core Verb** (single most common player action)
- **Core Fantasy** (emotional promise)
- **Unique Hook** (passes the "and also" test)
- **Primary MDA Aesthetic** (which emotion dominates)
- **Estimated Scope** (small / medium / large)
- **Why It Could Work** and **Biggest Risk**

---

### Phase 3: Core Loop Design

For the chosen concept:

**30-Second Loop** (moment-to-moment): What's the core action? Is it intrinsically satisfying?
**5-Minute Loop** (short-term goals): What structures play into cycles?
**Session Loop** (30-120 minutes): What does a complete session look like?
**Progression Loop** (days/weeks): How does the player grow?

**Player Motivation** (Self-Determination Theory):
- Autonomy, Competence, Relatedness

---

### Phase 4: Pillars and Boundaries

Define **3-5 pillars**:
- Name + one-sentence definition
- Design test: "If debating X vs Y, this pillar says..."

Define **3+ anti-pillars** (what this game is NOT).

---

### Phase 5: Player Type Validation

Using Bartle taxonomy:
- Primary player type
- Secondary appeal
- Who is this NOT for

---

### Phase 6: Scope and Feasibility

- **Engine**: Flax Engine 1.11 (already configured)
- **Art pipeline**: What style? How labor-intensive?
- **Content scope**: Level count, gameplay hours
- **MVP definition**: Minimum build to test core loop
- **Biggest risks**: Technical, design, market
- **Scope tiers**: Full vision vs. minimum shippable

---

### Phase 7: Generate Game Concept Document

Write to `design/gdd/game-concept.md` using the template at `.claude/docs/templates/game-concept.md`.

**Next steps after brainstorm**:
1. `/art-bible` — define visual identity
2. `/map-systems` — decompose into systems
3. `/design-system` — author per-system GDDs
4. `/create-architecture` — architecture blueprint
5. `/prototype [core-mechanic]` — validate the core loop
6. `/sprint-plan new` — first sprint

Verdict: **COMPLETE** — game concept created.
