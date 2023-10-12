using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUnit : MonoBehaviour
{
    public List<GameObject> TargetsInRange;
    public AttackSO AttackSO;
    protected Rigidbody Rigidbody;
    public PlayerInput Input;

    public const string Green = "Green";
    public const string Red = "Red";
    public const string Object = "Object";

    protected void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();
        Input = GetComponent<PlayerInput>();

    }
    protected virtual void Attack()
    {

    }
    protected string PerformRaycast()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            string hitObjectTag = hit.collider.tag;
            Debug.Log("Hit object with tag: " + hitObjectTag);
            return hitObjectTag;
        }
        return null;
    }
}
