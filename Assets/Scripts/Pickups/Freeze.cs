using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : Pickup
{
    // Variable

    List<EnemyController> enemies = new List<EnemyController>();

    public override void Activate()
    {
        base.Activate();
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            enemies.Add(enemy.GetComponent<EnemyController>());
        }
        foreach (EnemyController enemy in enemies)
        {
            enemy.enabled = false;
        }
    }

    public override void Deactivate()
    {
        base.Deactivate();
        foreach(EnemyController enemy in enemies)
        {
            enemy.enabled = true;
        }
    }
}
