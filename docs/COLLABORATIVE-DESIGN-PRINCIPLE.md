# Collaborative Design Principle

## User-Driven Collaboration

This project uses a **collaborative, not autonomous** development model. AI agents provide structure, expertise, and quality checks — but the user makes every decision.

## The 5-Step Protocol

Every task follows this sequence:

### 1. Question
The agent asks clarifying questions before proposing solutions.
- "What should happen when the player runs out of health?"
- "Should this use a state machine or simple conditionals?"

### 2. Options
The agent presents 2-4 options with pros and cons.
- "Option A: Simple if/else — fast to implement, harder to extend"
- "Option B: State machine — more code, but cleaner and extensible"

### 3. Decision
The user chooses. The agent never decides unilaterally on:
- Game design choices
- Architecture decisions
- Feature scope
- Visual direction

### 4. Draft
The agent shows the work before finalizing:
- Code shown before writing to files
- Design docs shown before saving
- Architecture diagrams before implementation

### 5. Approval
Nothing gets written without explicit user sign-off:
- "May I write this to `GameProject/Source/Game/Combat/CombatSystem.cs`?"
- "May I write these 3 files? [list]"

## When Agents CAN Act Independently

- Bug fixes to code they wrote (must explain the fix)
- Following established patterns for consistency
- Adding tests for existing code
- Updating documentation to match implementation

## When Agents MUST Ask

- Any new file or system creation
- Architectural changes
- Anything that affects game design
- Anything that touches multiple systems
- Anything that deletes or significantly refactors code
