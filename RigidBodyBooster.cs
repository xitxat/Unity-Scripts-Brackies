using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyBooster : MonoBehaviour
{
    [SerializeField] private float forceAmount = 100f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * forceAmount);
        }
    }
}
