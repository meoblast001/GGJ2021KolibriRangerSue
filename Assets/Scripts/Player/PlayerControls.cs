﻿using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;

    private PlayerInput _input;

    private void Awake()
    {
        _input = new PlayerInput();

        _input.PlayerStandard.Move.started += ctx => Move(ctx.ReadValue<Vector2>());
        _input.PlayerStandard.Move.performed += ctx => Move(ctx.ReadValue<Vector2>());
        _input.PlayerStandard.Move.canceled += ctx => Move(ctx.ReadValue<Vector2>());

        _input.PlayerStandard.Look.started += ctx => Look(ctx.ReadValue<Vector2>());
        _input.PlayerStandard.Look.performed += ctx => Look(ctx.ReadValue<Vector2>());
        _input.PlayerStandard.Look.canceled += ctx => Look(ctx.ReadValue<Vector2>());

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
        if (Application.isEditor)
        {
            return;
        }

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        _input.Disable();
        if (Application.isEditor)
        {
            return;
        }

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
        GetComponent<InteractingActor>()?.Interact();
    }

    private void Throw()
    {
       GetComponent<InteractingActor>()?.Throw();
    }

    private void PickUp()
    {
       GetComponent<PlayerSockInteraction>()?.PickUpSock();
    }

    private void Drop()
    {
       // Debug.Log("Dropping");
    }

    private void SwapActive()
    {
       Application.Quit();
    }

    private void UseActive()
    {
       // Debug.Log("Use active");
    }

    private void DropSocks()
    {
       GetComponent<PlayerSockInteraction>()?.DropSocks();
    }
}
