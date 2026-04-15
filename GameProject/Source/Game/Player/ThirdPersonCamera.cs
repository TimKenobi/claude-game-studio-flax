using FlaxEngine;

/// <summary>
/// Third-person camera controller with orbit, follow, and collision avoidance.
/// Attach to a camera actor that follows the player.
/// Consider using SpringArmPlugin for more advanced camera behavior.
/// </summary>
public class ThirdPersonCamera : Script
{
    [Serialize, ShowInEditor, Header("Target")]
    private Actor _target;

    [Serialize, ShowInEditor]
    private Float3 _targetOffset = new Float3(0, 1.5f, 0);

    [Serialize, ShowInEditor, Header("Distance")]
    private float _distance = 5.0f;

    [Serialize, ShowInEditor]
    private float _minDistance = 2.0f;

    [Serialize, ShowInEditor]
    private float _maxDistance = 10.0f;

    [Serialize, ShowInEditor, Header("Rotation")]
    private float _mouseSensitivity = 2.0f;

    [Serialize, ShowInEditor]
    private float _minPitch = -30.0f;

    [Serialize, ShowInEditor]
    private float _maxPitch = 60.0f;

    [Serialize, ShowInEditor, Header("Smoothing")]
    private float _followSpeed = 10.0f;

    [Serialize, ShowInEditor, Header("Collision")]
    private float _collisionRadius = 0.3f;

    [Serialize, ShowInEditor]
    private LayersMask _collisionLayers = new LayersMask(uint.MaxValue);

    private float _yaw;
    private float _pitch = 15.0f;
    private float _currentDistance;

    public override void OnStart()
    {
        _currentDistance = _distance;

        if (_target == null)
        {
            Debug.LogWarning("ThirdPersonCamera: No target assigned.");
        }

        // Hide and lock cursor during gameplay
        Screen.CursorLock = CursorLockMode.Locked;
        Screen.CursorVisible = false;
    }

    public override void OnLateUpdate()
    {
        if (_target == null)
            return;

        if (GameManager.Instance != null && GameManager.Instance.CurrentState != GameState.Playing)
            return;

        HandleRotationInput();
        UpdateCameraPosition();
    }

    private void HandleRotationInput()
    {
        _yaw += Input.GetAxis("Mouse X") * _mouseSensitivity;
        _pitch -= Input.GetAxis("Mouse Y") * _mouseSensitivity;
        _pitch = Mathf.Clamp(_pitch, _minPitch, _maxPitch);

        // Scroll wheel zoom
        float scrollDelta = Input.GetAxis("Mouse ScrollWheel");
        _distance = Mathf.Clamp(_distance - scrollDelta * 2f, _minDistance, _maxDistance);
    }

    private void UpdateCameraPosition()
    {
        var targetPosition = _target.Position + _targetOffset;

        // Calculate desired camera position
        var rotation = Quaternion.Euler(_pitch, _yaw, 0);
        var desiredPosition = targetPosition - rotation * Float3.Forward * _distance;

        // Collision check — pull camera closer if blocked
        _currentDistance = _distance;
        if (Physics.SphereCast(targetPosition, _collisionRadius, Float3.Normalize(desiredPosition - targetPosition), out var hit, _distance, _collisionLayers))
        {
            _currentDistance = Mathf.Max(hit.Distance - _collisionRadius, _minDistance);
        }

        var finalPosition = targetPosition - rotation * Float3.Forward * _currentDistance;

        // Smooth follow
        Actor.Position = Float3.Lerp(Actor.Position, finalPosition, Time.DeltaTime * _followSpeed);
        Actor.Orientation = Quaternion.LookRotation(Float3.Normalize(targetPosition - Actor.Position), Float3.Up);
    }

    public override void OnDisable()
    {
        Screen.CursorLock = CursorLockMode.None;
        Screen.CursorVisible = true;
    }
}
