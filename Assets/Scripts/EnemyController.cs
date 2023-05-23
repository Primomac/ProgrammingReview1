using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Variables

    public float moveSpeed = 4f;
    public GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            transform.Translate((player.transform.position - transform.position).normalized * moveSpeed * Time.deltaTime);
        }
    }
}
