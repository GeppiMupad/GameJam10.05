using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GetInput : MonoBehaviour
{
    public Vector2 movement;
    public bool isSprinting = false;

    public void OnMovement(InputAction.CallbackContext _context)
    {
        movement = _context.ReadValue<Vector2>();
    }

    public void OnSprint(InputAction.CallbackContext _context)
    {
        if(_context.performed)
        {
            isSprinting = true;
        }
        else if(_context.canceled)
        {
            isSprinting = false;
        }

    }
}
