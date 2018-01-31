using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTowardBehavior : Behavior
{

    public GameObject target;
    public bool wentToTarget = false;
    public bool goToSecondTarget = false;
    // Use this for initialization


    public override void doBehaviour(BehaviorManager manager)
    {
        manager.agent.destination = target.transform.position;
    }

    public override bool checkBehavior(BehaviorManager manager)
    {
        return pathComplete(manager);
    }

    public override void updateBehavior(BehaviorManager manager)
    {
        if(checkBehavior(manager))
        {
            
            //goToSecondTarget = !goToSecondTarget;
            manager.behaviors.Pop();
            WalkTowardBehavior newWalk = manager.thingThatHoldsBehaviours.GetComponent<WalkTowardBehavior>();
            if(goToSecondTarget)
            {
                newWalk.target = manager.target2;
            }
            else
            { 
                newWalk.target = manager.target1;
            }
            goToSecondTarget = !goToSecondTarget;
            manager.behaviors.Push(newWalk);

        }
    }
}
