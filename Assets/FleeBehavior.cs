using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleeBehavior : MonoBehaviour
{

    Rigidbody rb;
    Rigidbody taggerRb;
    Vector3 desiredVelocity;
    Vector3 projectedPosition;
    public float speed;
    public float projectedDistance;
    public float currentSpeed;
    public float evadeRange;
    float EvadeDist;

    public Transform target;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(target.position, taggerRb.position);
        if(dist < EvadeDist)
        {
            rb.AddForce(transform.right * 20, ForceMode.Impulse);
        }
        else
        {
            projectedPosition = target.position + (taggerRb.velocity.normalized * projectedDistance);
            desiredVelocity = currentSpeed * (projectedPosition - transform.position).normalized;
            rb.AddForce(desiredVelocity - rb.velocity);
        }
    }
}

