using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControl : MonoBehaviour
{
    [SerializeField] private float tiltSpeed = 150f;

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.forward, angle:horizontal * Time.deltaTime * tiltSpeed);
    }
}
