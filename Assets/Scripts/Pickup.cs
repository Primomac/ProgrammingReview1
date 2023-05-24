using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pickup : MonoBehaviour
{
    // Variables

    public Collider2D coll;
    public SpriteRenderer sprite;
    public float duration;

    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Activate is called when the Player makes contact with the Pickup
    public virtual void Activate()
    {
        // Do stuff here
    }

    public virtual void Deactivate()
    {
        // Undo stuff here
    }

    // DelayedDestroy determines when the effect of Activate ends
    public virtual IEnumerator DelayedDestroy(float seconds)
    {
        coll.enabled = false;
        sprite.enabled = false;
        yield return new WaitForSeconds(seconds);
        Deactivate();
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Activate();
            StartCoroutine(DelayedDestroy(duration));
        }
    }
}
