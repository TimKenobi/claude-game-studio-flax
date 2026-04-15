using System.Collections.Generic;
using FlaxEngine;

/// <summary>
/// Generic object pool for frequently spawned actors (projectiles, VFX, enemies).
/// Reduces GC pressure from repeated Instantiate/Destroy cycles.
/// Inspired by FlaxObjectPool plugin from awesome-flax.
/// </summary>
public class ObjectPool : Script
{
    [Serialize, ShowInEditor]
    private Prefab _prefab;

    [Serialize, ShowInEditor]
    private int _initialPoolSize = 10;

    [Serialize, ShowInEditor]
    private int _maxPoolSize = 50;

    private readonly Queue<Actor> _available = new();
    private readonly HashSet<Actor> _active = new();

    public int ActiveCount => _active.Count;
    public int AvailableCount => _available.Count;

    public override void OnStart()
    {
        if (_prefab == null)
        {
            Debug.LogError("ObjectPool: No prefab assigned.");
            return;
        }

        for (int i = 0; i < _initialPoolSize; i++)
        {
            CreatePooledInstance();
        }
    }

    /// <summary>
    /// Get an actor from the pool. Returns null if pool is exhausted and at max.
    /// </summary>
    public Actor Get(Float3 position, Quaternion rotation)
    {
        Actor instance;

        if (_available.Count > 0)
        {
            instance = _available.Dequeue();
        }
        else if (_active.Count < _maxPoolSize)
        {
            instance = CreatePooledInstance();
        }
        else
        {
            Debug.LogWarning($"ObjectPool: Max pool size ({_maxPoolSize}) reached for {_prefab.Name}.");
            return null;
        }

        instance.Transform = new Transform(position, rotation);
        instance.IsActive = true;
        _active.Add(instance);

        // Notify scripts on the pooled actor
        var poolable = instance.GetScript<IPoolable>();
        poolable?.OnGetFromPool();

        return instance;
    }

    /// <summary>
    /// Return an actor to the pool.
    /// </summary>
    public void Return(Actor instance)
    {
        if (instance == null || !_active.Contains(instance))
            return;

        var poolable = instance.GetScript<IPoolable>();
        poolable?.OnReturnToPool();

        instance.IsActive = false;
        _active.Remove(instance);
        _available.Enqueue(instance);
    }

    /// <summary>
    /// Return all active instances to the pool.
    /// </summary>
    public void ReturnAll()
    {
        var activeList = new List<Actor>(_active);
        foreach (var instance in activeList)
        {
            Return(instance);
        }
    }

    private Actor CreatePooledInstance()
    {
        var instance = PrefabManager.SpawnPrefab(_prefab, Actor);
        instance.IsActive = false;
        _available.Enqueue(instance);
        return instance;
    }

    public override void OnDestroy()
    {
        _available.Clear();
        _active.Clear();
    }
}

/// <summary>
/// Interface for scripts on pooled actors to handle activation/deactivation.
/// </summary>
public interface IPoolable
{
    void OnGetFromPool();
    void OnReturnToPool();
}
