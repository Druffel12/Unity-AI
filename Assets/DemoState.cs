using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public enum States
{
    wanderState,//0
    arriveState,//1
    fleeState,//2
    startoverState,//3
}

public class DemoState : MonoBehaviour {

    NavMeshAgent agent;
    WanderBehavior wander;
    SeekBehavior seek;
    FleeBehavior flee;
    States currentState;

    public float transitionTime;
    float timer;

	// Use this for initialization
	void Start ()
    {
        timer = transitionTime;
        agent = GetComponent<NavMeshAgent>();
        wander = GetComponent<WanderBehavior>();
        seek = GetComponent<SeekBehavior>();
        flee = GetComponent<FleeBehavior>();

	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
