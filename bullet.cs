using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 10f;
    public ParticleSystem explode;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.up * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        explode.Play();
        rb.velocity = transform.up * 0;
        Invoke("destroy", 0.1f);
    }
    void destroy()
    {
        Destroy(gameObject);
    }
}
