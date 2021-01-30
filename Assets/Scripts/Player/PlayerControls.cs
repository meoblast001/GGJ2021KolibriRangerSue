using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private PlayerInput _input;

    private void Awake()
    {
        _input = new PlayerInput();

        _input.PlayerStandard.Move.started += ctx => { Debug.Log($"Started {ctx.ReadValue<Vector2>()}"); Move(ctx.ReadValue<Vector2>()); };
        _input.PlayerStandard.Move.performed += ctx => { Debug.Log($"Performed {ctx.ReadValue<Vector2>()}"); Move(ctx.ReadValue<Vector2>()); Move(ctx.ReadValue<Vector2>()); };
        _input.PlayerStandard.Move.canceled += ctx => { Debug.Log($"Canceled {ctx.ReadValue<Vector2>()}"); Move(ctx.ReadValue<Vector2>()); Move(ctx.ReadValue<Vector2>()); };

        _input.PlayerStandard.Look.started += ctx =>{ Debug.Log($"R Started {ctx.ReadValue<Vector2>()}"); Look(ctx.ReadValue<Vector2>()); };
        _input.PlayerStandard.Look.performed += ctx =>  { Debug.Log($"R Performed {ctx.ReadValue<Vector2>()}"); Look(ctx.ReadValue<Vector2>()); };
        _input.PlayerStandard.Look.canceled += ctx => { Debug.Log($"R Canceled {ctx.ReadValue<Vector2>()}"); Look(ctx.ReadValue<Vector2>()); };

        _input.PlayerStandard.Collect.performed += _ => Interact();
        _input.PlayerStandard.Throw.performed += _ => Throw();
        _input.PlayerStandard.PickUp.performed += _ => PickUp();
        _input.PlayerStandard.Drop.performed += _ => Drop();
        _input.PlayerStandard.SwapActive.performed += _ => SwapActive();
        _input.PlayerStandard.UseActive.performed += _ => UseActive();
        _input.PlayerStandard.DropSocks.performed += _ => DropSocks();
    }

    private void OnEnable()
    {
        _input.Enable();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        _input.Disable();
        Cursor.lockState = CursorLockMode.None;
    }

    private void Move(Vector2 direction)
    {
        _playerMovement.MoveDeltaDirection = direction;
    }

    private void Look(Vector2 direction)
    {
        _playerMovement.LookDeltaDirection = direction;
    }

    private void Interact()
    {
        Debug.Log("Interacting");
    }

    private void Throw()
    {
        Debug.Log("Throwing");
    }

    private void PickUp()
    {
        Debug.Log("Picking up");
    }

    private void Drop()
    {
        Debug.Log("Dropping");
    }

    private void SwapActive()
    {
        Debug.Log("Swapping active");
    }

    private void UseActive()
    {
        Debug.Log("Use active");
    }

    private void DropSocks()
    {
        Debug.Log("Drop socks");
    }
}
