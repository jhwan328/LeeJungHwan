using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangedAttackUnit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball_Red"))
        {
            Debug.Log("Hit!");
            this.gameObject.SetActive(false);
        }
    }
   
}
