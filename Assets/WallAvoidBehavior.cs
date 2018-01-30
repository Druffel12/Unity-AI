using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAvoidBehavior : MonoBehaviour
{

    Rigidbody rb;
    public float avoidanceStrength;
    public float avoidanceRange;
    Vector3 wallDir;

   
	// Use this for initialization
	void Start ()
    {
        
        rb = GetComponent<Rigidbody>();	
	}
	
    public void doWallAvoidance()
    {
        RaycastHit Hit;

        if(Physics.Raycast(transform.position, wallDir, out Hit, rb.velocity.magnitude))
        {
            rb.AddForce(Hit.normal * avoidanceStrength);
        }
    }
	// Update is called once per frame
	void Update ()
    {
        doWallAvoidance();
	}
}
