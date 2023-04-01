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
        transform.Translate(dir * Time.deltaTime * Random.Range(1f, 10f));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
