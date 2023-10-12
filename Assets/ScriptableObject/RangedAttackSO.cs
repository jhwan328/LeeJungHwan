using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RangedAttackData", menuName = "UserScriptableObject/Attacks/Ranged", order = 1)]

public class RangedAttackSO : AttackSO
{
    [Header("Ranged Attack Data")]
    public GameObject Prefab;
    public int ProjectilePerShoot;
    public float ShootRange;
    public float ProjectileSpeed;
}
