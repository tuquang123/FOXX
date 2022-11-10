using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossFight : MonoBehaviour
{
    public float speed = 5;
    public Transform player;
    public float dir = 1;
    public Animator anm;
    public bool attack;

    public int hp = 20;
    public GameObject fx;

    private void Update()
    {
        LookAtPlayer();
        if(Vector2.Distance(transform.position,player.position) > dir)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else
        {
            anm.SetTrigger("Attack");     
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bulletPlayer"))
        {
            hp--;

            if(hp <= 0)
            {
                Destroy(gameObject);
                Instantiate(fx, transform.position, Quaternion.identity);
            }
        }
    }
    public bool isFlipped = false;

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;

        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

}
