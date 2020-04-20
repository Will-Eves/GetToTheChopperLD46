using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heliMovment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1.0f;
    public GameObject gameM;
    bool score;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(speed, 0.0f);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag != "missile")
        {
            if (hitInfo.tag != "bullet")
            {
                if (hitInfo.tag != "end")
                {

                }
                else
                {
                    FindObjectOfType<GameM>().Score();
                }
            }
            else
            {
                FindObjectOfType<GameM>().damage();
            }
        }
        else
        {
            FindObjectOfType<GameM>().damage();
        }
        Destroy(gameObject);
    }
}
