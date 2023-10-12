using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttackController : MonoBehaviour
{
    private Vector3 Direction;
    private Rigidbody Rigidbody;
    private TrailRenderer TrailRenderer;
    private void Awake()
    {
        TrailRenderer = GetComponent<TrailRenderer>();
        Rigidbody = GetComponent<Rigidbody>();
    }
   
    public void SetDirection(Vector3 direction)
    {
        this.Direction = direction;
        TrailRenderer.Clear();
    }

    private void Update()
    {
        Rigidbody.AddForce(Direction);
    }
}
