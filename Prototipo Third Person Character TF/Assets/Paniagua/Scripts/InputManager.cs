using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    Player_Controls playerControls;

    [SerializeField] Vector2 movementInput;
    [SerializeField] public float VInput;
    [SerializeField] public float HInput;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new Player_Controls();

            playerControls.PlayerMovement.Movement.performed += i => movementInput = i.ReadValue<Vector2>();
        }
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
    }

    private void HandleMovementInput()
    {
        VInput = movementInput.y;
        HInput = movementInput.x;
    }
}
