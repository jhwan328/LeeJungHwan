using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactAttackUnit : BaseUnit
{
    protected override void Attack()
    {
        base.Attack();
        Debug.Log("Attack In ContactAttackUnit");
       
    }
}
