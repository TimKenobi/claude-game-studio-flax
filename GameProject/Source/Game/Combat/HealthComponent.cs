using FlaxEngine;

/// <summary>
/// Base health component for any damageable actor (player, enemies, destructibles).
/// Attach to any actor that can take damage.
/// </summary>
public class HealthComponent : Script
{
    [Serialize, ShowInEditor]
    private float _maxHealth = 100f;

    [Serialize, ShowInEditor]
    private float _currentHealth;

    [Serialize, ShowInEditor]
    private bool _isInvulnerable;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _currentHealth;
    public float HealthPercent => _maxHealth > 0 ? _currentHealth / _maxHealth : 0f;
    public bool IsAlive => _currentHealth > 0;
    public bool IsInvulnerable { get => _isInvulnerable; set => _isInvulnerable = value; }

    public override void OnStart()
    {
        _currentHealth = _maxHealth;
    }

    /// <summary>
    /// Apply damage to this actor. Returns actual damage dealt.
    /// </summary>
    public float TakeDamage(float damage, Actor source = null)
    {
        if (!IsAlive || _isInvulnerable || damage <= 0f)
            return 0f;

        float actualDamage = Mathf.Min(damage, _currentHealth);
        _currentHealth -= actualDamage;

        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            OnDeath(source);
        }

        return actualDamage;
    }

    /// <summary>
    /// Heal this actor. Returns actual amount healed.
    /// </summary>
    public float Heal(float amount)
    {
        if (!IsAlive || amount <= 0f)
            return 0f;

        float actualHeal = Mathf.Min(amount, _maxHealth - _currentHealth);
        _currentHealth += actualHeal;
        return actualHeal;
    }

    /// <summary>
    /// Reset health to maximum.
    /// </summary>
    public void ResetHealth()
    {
        _currentHealth = _maxHealth;
    }

    private void OnDeath(Actor source)
    {
        // Determine if this is the player or an enemy and publish appropriate event
        if (Actor.HasTag("Player"))
        {
            EventBus.Publish(new PlayerDeathEvent { DeathPosition = Actor.Position });
        }
        else
        {
            EventBus.Publish(new EnemyDeathEvent { Enemy = Actor, Position = Actor.Position });
        }
    }
}
