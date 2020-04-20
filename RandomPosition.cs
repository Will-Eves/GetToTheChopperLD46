using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPosition : MonoBehaviour
{
    public float max;
    public float min;
    float spawnTime = 3.5f;
    public GameObject heli;
    void Awake()
    {
        Vector2 position = new Vector2(-9.1f, Random.Range(max, min));
        transform.position = position;
        Invoke("Spawn", spawnTime);
    }
    void Spawn()
    {
        Vector2 position = new Vector2(-9.1f, Random.Range(max, min));
        transform.position = position;
        Instantiate(heli, transform.position, transform.rotation);
        Invoke("Spawn", spawnTime);
    }
}
