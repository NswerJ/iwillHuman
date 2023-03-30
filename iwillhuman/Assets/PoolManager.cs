using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private GameObject poolObj;

    public static PoolManager instance;
    public float count  = 25;

    public List<GameObject> list = new List<GameObject>();
    private void Awake()
    { 
        instance = this;
        for (int i = 0; i < count; i++)
        {
            GameObject obj = Instantiate(poolObj);
            list.Add(obj);
            list[i].transform.SetParent(transform);
        }
    }

    public void Pop()
    {

    }

    



    
}
