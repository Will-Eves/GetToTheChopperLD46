using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class missileMovment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 2.0f;
    public ParticleSystem explode;
    public GameObject gameM;
    bool score;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.velocity = transform.up * -speed;
    }
    void OnTriggerEnter2D()
    {
        explode.Play();
        rb.velocity = transform.up * 0;
        trigger();
    }
    void trigger()
    {
        Destroy(gameObject);
    }
}
