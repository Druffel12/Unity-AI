using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPack : Behavior
{
    public GameObject HP;
    public override void doBehaviour(BehaviorManager manager)
    {
        manager.agent.destination = HP.transform.position;
    }

    public override bool checkBehavior(BehaviorManager manager)
    {
        if (pathComplete(manager))
        {
            manager.HP += 50;
            return true;
        }
        return false;
    }

    public override void updateBehavior(BehaviorManager manager)
    {
        if(checkBehavior(manager))
        {
            manager.behaviors.Pop();
        }

    }

}
