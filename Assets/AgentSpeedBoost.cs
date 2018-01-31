using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentSpeedBoost : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
    private void OnCollisionEnter(Collision collision)
    {
        NavMeshAgent agent = collision.collider.GetComponent<NavMeshAgent>();
        if(agent != null)
        {
            agent.speed += 5;

        }
    }

}
