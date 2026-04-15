---
name: architecture-review
description: "Review the current codebase architecture for SOLID compliance, Flax best practices, and technical health."
argument-hint: "[system name or 'full']"
user-invocable: true
allowed-tools: ["Read File", "Write File", "Edit File", "List Directory", "Search Files", "Grep Search"]
---

# Architecture Review Skill

## Purpose
Evaluate codebase architecture for quality, maintainability, and adherence to Flax Engine best practices.

## Review Criteria

### SOLID Principles
- **SRP**: Does each class have one responsibility?
- **OCP**: Can systems be extended without modification?
- **LSP**: Do derived classes honor base contracts?
- **ISP**: Are interfaces focused (no fat interfaces)?
- **DIP**: Do high-level modules depend on abstractions?

### Flax-Specific Patterns
- [ ] Scripts use proper lifecycle (`OnEnable`, `OnDisable`, `OnUpdate`)
- [ ] Actor references cached in `OnStart()`, not fetched per frame
- [ ] Events used for cross-system communication (not direct references)
- [ ] Prefabs used for reusable actor configurations
- [ ] Scene organization follows project structure conventions
- [ ] `[Serialize]` used correctly for editor-exposed fields
- [ ] No heavy work in constructors (use `OnStart`)

### Architecture Health
- [ ] No circular dependencies between systems
- [ ] Clear system boundaries (each system in its own directory)
- [ ] Service locator or dependency injection for shared services
- [ ] Data flows in expected directions (input → logic → output)
- [ ] No hardcoded scene references or actor names

### Code Quality
- [ ] Naming conventions followed (PascalCase public, _camelCase private)
- [ ] No classes over 300 lines
- [ ] No methods over 50 lines
- [ ] Magic numbers extracted to constants
- [ ] Error handling present at system boundaries

## Workflow
1. Scan source files in target directory
2. Apply each review criterion
3. Generate findings report with severity
4. Recommend fixes for critical issues
5. Create tech-debt entries for non-critical issues

## Output
- Architecture review report
- Tech-debt entries for issues found
