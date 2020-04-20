using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosX : MonoBehaviour
{
    public float max;
    public Transform user;
    public float min;
    float spawnTime = 1.5f;
    public GameObject missile;
    void Awake()
    {
        Vector2 position = new Vector2(Random.Range(max, min), 5.1f);
        transform.position = position;
        Invoke("Spawn", spawnTime + 3.5f);
    }
    void Update()
    {
        if(user.position.y >= 3)
        {
            max = user.position.x + 0.5F;
            min = user.position.x - 0.5F;
        }
        else
        {
            max = 6.7F;
            min = -6.7F;
        }
    }
    void Spawn()
    {
        Vector2 position = new Vector2(Random.Range(max, min), 5.1f);
        transform.position = position;
        Instantiate(missile, transform.position, transform.rotation);
        Invoke("Spawn", spawnTime);
    }
}
