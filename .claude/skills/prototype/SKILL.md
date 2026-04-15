---
name: prototype
description: "Build a quick throwaway prototype to validate a game mechanic or technical approach. Isolated from production code."
argument-hint: "[mechanic-name] (e.g., combat, movement, dialog)"
user-invocable: true
allowed-tools: Read, Glob, Grep, Write, Edit, Bash
---

When this skill is invoked:

## 1. Define the Hypothesis

Ask: "What question does this prototype answer?"
- e.g., "Is sword combat fun with this timing window?"
- e.g., "Can we load levels fast enough for seamless transitions?"

## 2. Define Scope

- What's the MINIMUM needed to test the hypothesis?
- What can be faked/stubbed? (Use cubes instead of models, placeholder sounds)
- Time budget: How long should this take to build?

## 3. Create Prototype Structure

```
prototypes/[mechanic-name]/
  README.md              # Hypothesis, setup instructions, findings
  Content/               # Prototype scenes and assets
  Source/                # Prototype scripts (C#)
```

## 4. Build the Prototype

- Use FlaxPrototypeTools for blockout geometry
- Relaxed coding standards (it's throwaway)
- Use Flax primitives and built-in materials
- Focus on the FEEL, not the look

## 5. Document Findings

Update `prototypes/[mechanic-name]/README.md`:
- Was the hypothesis confirmed or rejected?
- What did we learn?
- What should change in the design?
- What should carry into production (concepts, not code)?

## 6. Suggest Next Steps

- If validated: `/design-system [system]` to finalize the GDD with learnings
- If rejected: `/brainstorm` to explore alternatives
- `/playtest-report` to document formal playtest results

Verdict: **COMPLETE** — prototype built and hypothesis tested.
