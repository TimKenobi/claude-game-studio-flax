using System;
using System.Collections.Generic;
using FlaxEngine;

/// <summary>
/// Lightweight event bus for decoupled cross-system communication.
/// Systems publish events; other systems subscribe without direct references.
/// </summary>
public static class EventBus
{
    private static readonly Dictionary<Type, List<Delegate>> _listeners = new();

    /// <summary>
    /// Subscribe to an event type.
    /// </summary>
    public static void Subscribe<T>(Action<T> handler) where T : struct
    {
        var type = typeof(T);
        if (!_listeners.TryGetValue(type, out var list))
        {
            list = new List<Delegate>();
            _listeners[type] = list;
        }
        list.Add(handler);
    }

    /// <summary>
    /// Unsubscribe from an event type.
    /// </summary>
    public static void Unsubscribe<T>(Action<T> handler) where T : struct
    {
        var type = typeof(T);
        if (_listeners.TryGetValue(type, out var list))
        {
            list.Remove(handler);
        }
    }

    /// <summary>
    /// Publish an event to all subscribers.
    /// </summary>
    public static void Publish<T>(T eventData) where T : struct
    {
        var type = typeof(T);
        if (_listeners.TryGetValue(type, out var list))
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] is Action<T> handler)
                {
                    handler.Invoke(eventData);
                }
            }
        }
    }

    /// <summary>
    /// Clear all listeners. Call on scene unload to prevent leaks.
    /// </summary>
    public static void Clear()
    {
        _listeners.Clear();
    }
}

// ---- Common Game Events ----

public struct PlayerDamagedEvent
{
    public float Damage;
    public Float3 SourcePosition;
    public Actor Source;
}

public struct PlayerHealedEvent
{
    public float Amount;
}

public struct PlayerDeathEvent
{
    public Float3 DeathPosition;
}

public struct EnemyDeathEvent
{
    public Actor Enemy;
    public Float3 Position;
}

public struct SceneTransitionEvent
{
    public string TargetScene;
    public string SpawnPointId;
}

public struct DialogStartedEvent
{
    public string DialogId;
    public Actor Speaker;
}

public struct DialogEndedEvent
{
    public string DialogId;
}

public struct GameStateChangedEvent
{
    public GameState PreviousState;
    public GameState NewState;
}
