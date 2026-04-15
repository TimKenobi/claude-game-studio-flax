using FlaxEngine;

/// <summary>
/// Third-person player controller for a 3D linear fantasy game.
/// Handles movement, jumping, and basic interaction via Flax's CharacterController.
/// </summary>
public class PlayerController : Script
{
    [Serialize, ShowInEditor, Header("Movement")]
    private float _moveSpeed = 5.0f;

    [Serialize, ShowInEditor]
    private float _sprintMultiplier = 1.6f;

    [Serialize, ShowInEditor]
    private float _rotationSpeed = 10.0f;

    [Serialize, ShowInEditor, Header("Jump")]
    private float _jumpForce = 8.0f;

    [Serialize, ShowInEditor]
    private float _gravity = -20.0f;

    private CharacterController _controller;
    private Float3 _velocity;
    private bool _isGrounded;

    public bool IsMoving => _velocity.LengthSquared > 0.01f;
    public bool IsGrounded => _isGrounded;

    public override void OnStart()
    {
        _controller = Actor.As<CharacterController>();
        if (_controller == null)
        {
            Debug.LogError("PlayerController requires a CharacterController on the same Actor.");
            Enabled = false;
        }
    }

    public override void OnUpdate()
    {
        if (GameManager.Instance != null && GameManager.Instance.CurrentState != GameState.Playing)
            return;

        HandleMovement();
        HandleJump();
        ApplyGravity();
        ApplyMovement();
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        var camera = Camera.MainCamera;
        if (camera == null)
            return;

        // Get camera-relative directions (flatten to XZ plane)
        var camForward = camera.Transform.Forward;
        camForward.Y = 0;
        camForward = Float3.Normalize(camForward);

        var camRight = camera.Transform.Right;
        camRight.Y = 0;
        camRight = Float3.Normalize(camRight);

        var moveDirection = (camForward * vertical + camRight * horizontal);
        if (moveDirection.LengthSquared > 1f)
            moveDirection = Float3.Normalize(moveDirection);

        bool isSprinting = Input.GetAction("Sprint");
        float speed = _moveSpeed * (isSprinting ? _sprintMultiplier : 1f);

        _velocity.X = moveDirection.X * speed;
        _velocity.Z = moveDirection.Z * speed;

        // Rotate character to face movement direction
        if (moveDirection.LengthSquared > 0.01f)
        {
            var targetRotation = Quaternion.LookRotation(moveDirection, Float3.Up);
            Actor.Orientation = Quaternion.Slerp(
                Actor.Orientation,
                targetRotation,
                Time.DeltaTime * _rotationSpeed
            );
        }
    }

    private void HandleJump()
    {
        if (_isGrounded && Input.GetAction("Jump"))
        {
            _velocity.Y = _jumpForce;
        }
    }

    private void ApplyGravity()
    {
        if (_isGrounded && _velocity.Y < 0)
        {
            _velocity.Y = -2f; // Small downward force to maintain ground contact
        }
        else
        {
            _velocity.Y += _gravity * Time.DeltaTime;
        }
    }

    private void ApplyMovement()
    {
        if (_controller != null)
        {
            _controller.Move(_velocity * Time.DeltaTime);
            _isGrounded = _controller.IsGrounded;
        }
    }
}
