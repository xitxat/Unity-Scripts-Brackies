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

    #region Singleton

    public static ObjectPooler instance;

    private void Awake()
        {
        instance = this;
        }
    

    #endregion

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

    // respawn inactive cubes
    // return a GameObject
    public GameObject SpawnFromPool (string tag, Vector3 position, Quaternion rotation)
    {
        // check for tag
        if (!poolDictionary.ContainsKey(tag))
        {
            Debug.LogWarning("Pool w tag " + tag + " doesn't exist");
            return null; // if no object
        }

        // get the preFab
        // recycle first objects out 
        GameObject  objectToSpawn = poolDictionary[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        // and put back in queue
        poolDictionary[tag].Enqueue(objectToSpawn);

        return objectToSpawn;

    }




} // end ObjectPooler
