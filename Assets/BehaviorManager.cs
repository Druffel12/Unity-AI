using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BehaviorManager : MonoBehaviour, IDamageable
{

    public float HP;
    public void takeDamage(float damage)
    {
        HP -= damage;
    }

    [HideInInspector]
    public Stack<Behavior> behaviors;
    [HideInInspector]
    public NavMeshAgent agent;
    public GameObject thingThatHoldsBehaviours;

    public GameObject target1;
    public GameObject target2;
    //public Transform walkTarget;
    // Use this for initialization
    void Start ()
    {


        agent = GetComponent<NavMeshAgent>();
        behaviors = new Stack<Behavior>();

        // WalkTowardBehavior attemptPush = thingThatHoldsBehaviours.GetComponent<WalkTowardBehavior>();
        //  behaviors.Push(attemptPush);
        //newWalkBehaviour.target = walkTarget;
        //behaviours.Push(newWalkBehaviour);
        GoToAcidBehavior attempt = thingThatHoldsBehaviors.GetComponent
            <GoToAcidBehaviors>();
        attempt.acid = acid;
        behaviors.Push(attempt)


	}
	
	// Update is called once per frame
	void Update ()
    {
		if(behaviors.Count > 0)
        {
            behaviors.Peek().doBehaviour(this);
            behaviors.Peek().updateBehavior(this);
        }
        else
        {
            Debug.Log("I have no behaviors");
        }
	}
}
