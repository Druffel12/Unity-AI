using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterposeBehavior : MonoBehaviour {


    public Transform thing1;
    public Transform thing2;
    public float speed;
  

    Rigidbody rb;
	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
    void ArriveAtPoints ( Vector3 targetPos )
    {
        Vector3 targetOffset = thing1.position - transform.position;
        float dist = Vector3.Distance(transform.position, thing2.position);
        float rampedSpeed = speed * (targetOffset.sqrMagnitude / dist);
        float clippedSpeed = Mathf.Min(rampedSpeed, speed);
        Vector3 desiredVelocity = (clippedSpeed / targetOffset.magnitude) * targetOffset;
        //rb.velocity = desiredVelocity;	
        rb.AddForce(desiredVelocity - rb.velocity);
    }
	// Update is called once per frame
	void Update ()
    {
        Vector3 midPoint = thing1.position - thing2.position;
        float midPointTime = Vector3.Distance(midPoint, transform.position) / speed;

        Vector3 aPos = thing1.position + thing1.GetComponent<Rigidbody>().velocity; 
	}
}
