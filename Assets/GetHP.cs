using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetHP : MonoBehaviour {

    public GameObject acid;

    public override void doBehaviour(BehaviorManager manager)
    {
        manager.agent.destination = acid.transform.position;
    }

    public override bool checkBehavior(BehaviorManager manager)
    {
        if (manager.HP < 25)
        {
            return false;
        }
    }

    public override void updateBehavior(BehaviorManager manager)
    {
        if(checkBehavior(manager))
        {
            //push get HP pack
        }

    }

}
