# Flax Engine — Version Reference

| Field | Value |
|-------|-------|
| **Engine Version** | 1.11 (Build 6810) |
| **Project Pinned** | 2026-04-14 |
| **LLM Knowledge Cutoff** | May 2025 |
| **Risk Level** | MEDIUM — version is near the edge of LLM training data |
| **Primary Language** | C# (.NET 7+) |
| **Secondary Language** | C++ |
| **Build System** | Flax.Build |

## Engine Source Availability

The full Flax Engine source is available in this workspace under `Source/`. This is the ground truth for API verification.

Key source directories:
- `Source/Engine/` — Engine C++ and C# source
- `Source/Editor/` — Editor C++ and C# source
- `Source/Shaders/` — HLSL shader source
- `Source/Platforms/` — Platform-specific code

## Key Flax 1.11 Features

- C# scripting with .NET 7+ runtime
- Clustered forward + deferred rendering
- PhysX physics integration
- Content pipeline (models, textures, materials, scenes, prefabs)
- Visual scripting (Visject)
- Navigation/NavMesh system
- Particle system
- Audio system (AudioSource, AudioClip, AudioListener)
- UICanvas/UIControl UI system
- Terrain system
- Plugin system

## Migration Notes

- Flax 1.11 uses .NET 7+ (not .NET Framework)
- UseDotNet: true in Flax.flaxproj
- C# scripting follows Flax Script lifecycle (OnEnable, OnDisable, OnStart, OnUpdate, etc.)

## Last Verified

2026-04-14
