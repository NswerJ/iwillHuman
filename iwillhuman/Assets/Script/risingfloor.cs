using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class risingfloor : MonoBehaviour
{
    public float _moveSpeed = 4f;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpandDown());

    }
    private void Update()
    {
        transform.position += dir * Time.deltaTime * _moveSpeed;
    }


    IEnumerator UpandDown()
    {
        while (true)
        {
            dir = Vector3.up;
            yield return new WaitForSeconds(1f);
            dir = Vector3.down;
            yield return new WaitForSeconds(1f);
        }
    }
}
