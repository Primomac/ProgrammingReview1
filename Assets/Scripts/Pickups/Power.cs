using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : Pickup
{
    public override void Activate()
    {
        base.Activate();
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isPowered = true;
    }

    public override void Deactivate()
    {
        base.Deactivate();
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().isPowered = false;
    }
}
