using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DefaultAttackData", menuName = "UserScriptableObject/Attacks/Default", order = 0)]
public class AttackSO : ScriptableObject
{
    public float AttackDamage;
    public float AttackDelay;
    public float MoveSpeed;
}
