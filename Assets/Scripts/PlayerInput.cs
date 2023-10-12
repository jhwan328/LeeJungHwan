using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerInputAction playerInputAction;
    public PlayerInputAction.PlayerActions playerActions;

    
    private void Awake()
    {
        playerInputAction = new PlayerInputAction();
        playerActions = playerInputAction.Player;
    }

    private void OnEnable()
    {
        playerInputAction.Enable();
    }

    private void OnDisable()
    {
        playerInputAction.Disable();
    }

    void OnFire()
    {
    
      
    }

    void OnMove(InputValue inputValue)
    {
        Debug.Log(inputValue);
    }


}
