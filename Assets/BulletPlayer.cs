using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPlayer : MonoBehaviour
{
    public GameObject fx;
    public float speed;
    Rigidbody2D rb;
    public AudioSource sfx;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bodyboss"))
        {
            Instantiate(fx, transform.position, Quaternion.identity);
            sfx.Play();
            Destroy(gameObject);
        }
    }
}
