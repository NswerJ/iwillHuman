using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private GameObject poolObj; // Ǯ���� ����(������)
    [SerializeField] private int poolSize; //Ǯ���� ����

    private List<GameObject> list = new List<GameObject>();

    public static PoolManager instance;

    private void Awake()
    {
        instance = this; //c#(instance = new PoolManager();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(poolObj); //Ǯ���� ���� ����
                                                   //Instantiate�� �÷��� �� ������ �Ǹ� ���� ���ϰ� �Ͼ�⿡ ���� ���� �����Ѵ�
            list.Add(obj); //����Ʈ�� Ǯ���� ������ �߰�
            list[i].transform.SetParent(transform); //����Ʈ�� i��° Ǯ���� ������ �ڽ�����
            list[i].gameObject.SetActive(false);
        }
    }

    public GameObject Pop(GameObject go) //�ҷ�����
    {

        go = list[0]; //go�� list[0]�� �ִ´�
        go.transform.SetParent(null); //go�� �θ� ���ش� (�θ��� transform�� ���ָ� ���� �ʴ´�)
        go.SetActive(true);
        list.Remove(go); //����Ʈ�� go�� �����
        return go; //Ǯ �Ŵ����� ���� �տ� �ִ� �༮�� ���°� �ش�.
    }

    public void Push(GameObject obj) //�־��ֱ�
    {//obj == Ǯ���� ����(poolObj)
        obj.transform.SetParent(transform); //�ٽ� obj�� �ڽ����� �����
        list.Add(obj); //����Ʈ�� obj�� �߰�
        obj.gameObject.SetActive(false);
    }


}
