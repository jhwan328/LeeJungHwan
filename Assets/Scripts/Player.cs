using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerInput Input;
    private Rigidbody Rigidbody;
    public AttackSO AttackSO;
    private PlayerStateMachine StateMachine;

    public int num = 0;
    private void Awake()
    {
        StateMachine = new PlayerStateMachine(this);
        Input = GetComponent<PlayerInput>();

    }

}
