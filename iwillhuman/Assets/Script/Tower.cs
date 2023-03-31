using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{

    public GameObject bullet;

    private void Start()
    {
        StartCoroutine(ShootBullet());
    }
    private void Update()
    {

    }

    IEnumerator ShootBullet()
    {
        while (true)
        {
            GameObject b = PoolManager.instance.Pop(bullet);
            b.transform.position = transform.position;
            yield return new WaitForSeconds(5f);
            PoolManager.instance.Push(b);
        }
    }
}
