using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Add this to Cube Spawner Obj + rigidbody
/// Needs CubeForceRandom on prefab spawnee
/// 
/// </summary>
public class CubeSpwaner : MonoBehaviour
{
    // pre singleton
    //public GameObject cubePrefab;

    // performance
    ObjectPooler objectPooler;

    private void Start()
    {
        objectPooler = ObjectPooler.instance;

    }


    private void FixedUpdate()
    {
        // 1 cube per update
        // pre singleton
        // Instantiate(cubePrefab, transform.position, Quaternion.identity);

        objectPooler.SpawnFromPool("Cube", transform.position, Quaternion.identity);

    }
}
