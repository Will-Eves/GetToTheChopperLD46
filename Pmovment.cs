using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pmovment : MonoBehaviour
{
    public float speed = 5.0f;
    bool facingRight = false;
    void Update()
    {
        input();
    }
    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(hitInfo.tag != "missile")
        {

        }
        else
        {
            FindObjectOfType<GameM>().endGame();
        }
    }
    void input()
    {
        Vector3 Scale = new Vector3(transform.localScale.x, 8, 1);
        Vector3 inverseScale = new Vector3(-transform.localScale.x, 8, 1);
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
        if (Input.GetKey("d"))
        {
            facingRight = true;
        }
        else if (Input.GetKey("a"))
        {
            facingRight = false;
        }

        if (facingRight = true)
        {
            transform.localScale = Scale;
        }
        else if (facingRight = false)
        {
            transform.localScale = inverseScale;
        }
    }
}
