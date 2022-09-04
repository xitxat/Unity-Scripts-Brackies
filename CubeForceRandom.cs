using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeForceRandom : MonoBehaviour
{

    public float upForce = 1f;
    public float sideForce = .1f;
    void Start()
    {
        
        float xForce = Random.Range(-sideForce, sideForce);
        float yForce = Random.Range(upForce/20f, upForce);
        float zForce = Random.Range(-sideForce, sideForce);

        Vector3 force = new Vector3(xForce, yForce, zForce);

        GetComponent<Rigidbody>().velocity = force;

    }
    
} // end
