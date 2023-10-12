using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool instance;
    [SerializeField] private GameObject Prefab;
    public Queue<GameObject> pool;
    public int poolSize = 20;
    private void Awake()
    {
        instance = this;
        pool = new Queue<GameObject>();
        for(int i = 0; i < poolSize; i++)
        {
            GameObject obj = Instantiate(Prefab);
            obj.SetActive(false);
            pool.Enqueue(obj);
        }
    }
    public GameObject SpawnFromPool()
    {
        GameObject obj = pool.Dequeue();
        pool.Enqueue(obj);
        return obj;
    }
}
