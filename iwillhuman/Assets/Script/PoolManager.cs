using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    [SerializeField] private GameObject poolObj; // 풀링할 옵젝(프리펩)
    [SerializeField] private int poolSize; //풀링할 개수

    private List<GameObject> list = new List<GameObject>();

    public static PoolManager instance;

    private void Awake()
    {
        instance = this; //c#(instance = new PoolManager();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(poolObj); //풀링할 옵젝 생성
                                                   //Instantiate는 플레이 중 실행이 되면 성능 저하가 일어나기에 실행 전에 실행한다
            list.Add(obj); //리스트에 풀링할 옵젝을 추가
            list[i].transform.SetParent(transform); //리스트에 i번째 풀링할 옵젝을 자식으로
            list[i].gameObject.SetActive(false);
        }
    }

    public GameObject Pop(GameObject go) //불러오기
    {

        go = list[0]; //go에 list[0]을 넣는다
        go.transform.SetParent(null); //go의 부모를 없앤다 (부모의 transform의 구애를 받지 않는다)
        go.SetActive(true);
        list.Remove(go); //리스트에 go를 지운다
        return go; //풀 매니저에 가장 앞에 있는 녀석을 빼온걸 준다.
    }

    public void Push(GameObject obj) //넣어주기
    {//obj == 풀링할 옵젝(poolObj)
        obj.transform.SetParent(transform); //다시 obj를 자식으로 만든다
        list.Add(obj); //리스트에 obj를 추가
        obj.gameObject.SetActive(false);
    }


}
