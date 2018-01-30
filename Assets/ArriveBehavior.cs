using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArriveBehavior : MonoBehaviour {

    Rigidbody rb;
    public float speed;
    public Transform target;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();	
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 targetOffset = target.position - transform.position;
        float dist = Vector3.Distance(transform.position, target.position);
        float rampedSpeed = speed * (targetOffset.sqrMagnitude / dist);
        float clippedSpeed = Mathf.Min(rampedSpeed, speed);
        Vector3 desiredVelocity = (clippedSpeed / targetOffset.magnitude) * targetOffset;
        //rb.velocity = desiredVelocity;	
        rb.AddForce(desiredVelocity - rb.velocity);
	}
}
