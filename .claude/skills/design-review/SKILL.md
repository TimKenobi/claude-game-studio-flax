---
name: design-review
description: "Review a system design document for completeness, consistency with pillars, and Flax Engine feasibility."
argument-hint: "<system GDD file path>"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Design Review Skill

## Purpose
Review a system GDD for quality, completeness, pillar alignment, and Flax Engine technical feasibility.

## Workflow

### Step 1: Read Documents
- Read the target system GDD
- Read `design/gdd/game-concept.md` and `design/gdd/game-pillars.md`
- Read `design/gdd/systems-index.md` for system relationships
- Read `.claude/docs/technical-preferences.md` for constraints

### Step 2: Evaluate
Check each criterion and rate GREEN/YELLOW/RED:

**Completeness**:
- [ ] All 8 required sections present (Overview, Core Mechanics, Data Structures, State Machines, Integration, Edge Cases, Polish, Testing)
- [ ] Formulas are specified for balanceable values
- [ ] Edge cases identified and handled

**Pillar Alignment**:
- [ ] System contributes to at least one design pillar
- [ ] No mechanics that contradict pillars
- [ ] Player experience aligns with core fantasy

**Technical Feasibility**:
- [ ] Can be implemented with Flax Engine 1.11 APIs
- [ ] Within performance budget (no unrealistic demands)
- [ ] Compatible with existing architecture
- [ ] Dependencies on other systems are reasonable

**Consistency**:
- [ ] No contradictions with other system GDDs
- [ ] Shared concepts use same definitions
- [ ] Data structures compatible across systems

### Step 3: Report
Create review notes directly in the GDD or in a separate review file:

```markdown
## Design Review — {date}
**Reviewer**: {agent}
**Overall**: APPROVED | APPROVED WITH NOTES | NEEDS REVISION

### Strengths
- {strength 1}

### Issues
- [{severity}] {issue description} — {recommendation}

### Suggestions
- {optional improvement}
```

## Output
- Review notes added to the GDD or as a separate file
- Status recommendation: proceed, revise, or redesign
