using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void Start()
    {

    }

    private void Update()
    {
        Vector2 dir = Vector2.left;
        transform.Translate(dir * Time.deltaTime * 4f);
    }
}
