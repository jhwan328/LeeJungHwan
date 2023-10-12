using System;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public AttackSO AttackSO;
    private BaseUnit BaseUnit;


    private void Start()
    {
        Debug.Log("Start");
        Invoke("OnAttack", 1.0f); 
    }
}
