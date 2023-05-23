using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables

    public GameManager game;

    public float moveSpeed = 5f;
    public Vector2 movement;
    public bool isDead = false;

    public SpriteRenderer sprite;
    public Sprite alive;
    public Sprite dead;
    public Sprite angy;

    // Start is called before the first frame update
    void Start()
    {
        game = GameObject.Find("GameManager").GetComponent<GameManager>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDead)
        {
            movement.x = Input.GetAxis("Horizontal");
            movement.y = Input.GetAxis("Vertical");
            transform.Translate(movement * moveSpeed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && !isDead)
        {
            isDead = true;
            game.lives--;
            sprite.sprite = dead;
            StartCoroutine(Respawn());
        }
    }

    public IEnumerator Respawn()
    {
        yield return new WaitForSeconds(3);
        sprite.sprite = alive;
        transform.position = new Vector2(Random.Range(-14, 15), Random.Range(-6, 7));
        isDead = false;
    }
}
