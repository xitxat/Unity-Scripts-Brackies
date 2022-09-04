using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [System.Serializable]
    public class Pool
    {
        public string tag;
        public GameObject prefab;
        public int size;
    }

    public List<Pool> pools;
    public Dictionary<string, Queue<GameObject>> poolDictionary;



    void Start()
    {
        
        poolDictionary = new Dictionary<string, Queue<GameObject>>();   

        foreach (Pool pool in pools)
        {
            //create a pool of game obj´s called objectPool
            Queue<GameObject> objectPool = new Queue<GameObject>();

            // fill the entire pool
            for (int i = 0; i < pool.size; i++)
            {
                // instantiate prefabs
                GameObject obj = Instantiate(pool.prefab);
                // remain unseen
                obj.SetActive(false);
                // add to end of queue
                objectPool.Enqueue(obj);
            }
            // add to Dictionary
            poolDictionary.Add(pool.tag, objectPool);
        }
    }


}
