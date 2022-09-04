using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Add this to Cube Spawner Obj + rigidbody
///     
/// </summary>
public class CubeSpwaner : MonoBehaviour
{
    public GameObject cubePrefab;


    private void FixedUpdate()
    {
        // 1 cube per update
        Instantiate(cubePrefab, transform.position, Quaternion.identity);
    }
}
