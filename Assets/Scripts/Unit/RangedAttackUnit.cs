using Palmmedia.ReportGenerator.Core.Reporting.Builders;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class RangedAttackUnit : BaseUnit
{
    [SerializeField] Transform projectileSpawnPoint;
    private float ProjectileSpeed=10.0f;
    public float rayLength = 30f;
    private void Start()
    {
        StartCoroutine(nameof(AttackCorutine));
    }
    protected override void Attack()
    {
        RangedAttackSO rangedAttackSO = AttackSO as RangedAttackSO;
        base.Attack();
        GameObject obj = ObjectPool.instance.SpawnFromPool();
        obj.transform.position = projectileSpawnPoint.position;
        obj.SetActive(true);
        RangedAttackController rangedAttackController = obj.GetComponent<RangedAttackController>();
        ProjectileSpeed = rangedAttackSO.ProjectileSpeed;
        rangedAttackController.SetDirection(this.transform.forward * ProjectileSpeed);
    }

    IEnumerator AttackCorutine()
    {
        while (true)
        {
            Attack();
            yield return new WaitForSeconds(1.0f);
        }
    }
}
