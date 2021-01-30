using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public PlayerInput _input;

    private void Awake()
    {
        Debug.Log($"Waking up {nameof(PlayerControls)}");
        _input = new PlayerInput();
        _input.PlayerStandard.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        _input.PlayerStandard.Interact.performed += _ => Interact();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void Move(Vector2 direction)
    {
        Debug.Log($"Moving in direction {direction}");
    }

    private void Interact()
    {
        Debug.Log("Interacting");
    }
}
