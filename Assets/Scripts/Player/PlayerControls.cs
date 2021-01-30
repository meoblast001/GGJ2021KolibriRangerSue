using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public PlayerInput _input;

    private void Awake()
    {
        Debug.Log($"Waking up {nameof(PlayerControls)}");
        _input = new PlayerInput();
        _input.PlayerStandard.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        _input.PlayerStandard.Look.performed += ctx => Look(ctx.ReadValue<Vector2>());
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
    }

    private void Move(Vector2 direction)
    {
        Debug.Log($"Moving in direction {direction}");
    }

    private void Look(Vector2 direction)
    {
        Debug.Log($"Looking in direction {direction}");
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
