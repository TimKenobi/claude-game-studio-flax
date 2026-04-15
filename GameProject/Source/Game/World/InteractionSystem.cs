using FlaxEngine;

/// <summary>
/// Simple interaction system — detects interactable objects in range 
/// and triggers interaction on player input.
/// </summary>
public class InteractionSystem : Script
{
    [Serialize, ShowInEditor]
    private float _interactionRange = 2.5f;

    [Serialize, ShowInEditor]
    private LayersMask _interactableLayers = new LayersMask(uint.MaxValue);

    private IInteractable _currentTarget;

    public IInteractable CurrentTarget => _currentTarget;
    public bool HasTarget => _currentTarget != null;

    public override void OnUpdate()
    {
        if (GameManager.Instance != null && GameManager.Instance.CurrentState != GameState.Playing)
            return;

        DetectInteractable();

        if (_currentTarget != null && Input.GetAction("Interact"))
        {
            _currentTarget.Interact(Actor);
        }
    }

    private void DetectInteractable()
    {
        _currentTarget = null;

        // Sphere cast forward from player to find interactable objects
        if (Physics.SphereCast(Actor.Position + new Float3(0, 1f, 0), 0.5f, Actor.Transform.Forward, out var hit, _interactionRange, _interactableLayers))
        {
            var interactable = hit.Collider?.GetScript<IInteractable>();
            if (interactable != null && interactable.CanInteract(Actor))
            {
                _currentTarget = interactable;
            }
        }
    }
}

/// <summary>
/// Interface for any interactable object in the world.
/// Implement on scripts attached to interactable actors.
/// </summary>
public interface IInteractable
{
    /// <summary>
    /// Display name shown in the interaction prompt UI.
    /// </summary>
    string InteractionPrompt { get; }

    /// <summary>
    /// Check if this object can currently be interacted with.
    /// </summary>
    bool CanInteract(Actor interactor);

    /// <summary>
    /// Execute the interaction.
    /// </summary>
    void Interact(Actor interactor);
}
