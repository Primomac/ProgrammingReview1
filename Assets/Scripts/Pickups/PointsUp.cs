using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsUp : Pickup
{
    // Variables

    public float points;

    public override void Activate()
    {
        base.Activate();
        GameObject.Find("GameManager").GetComponent<GameManager>().score += points;
    }
}
