using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePos : MonoBehaviour
{
    Vector2 pos;
    void Update()
    {
        pos = Input.mousePosition;
        transform.position = pos;
    }
}
