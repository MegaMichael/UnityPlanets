using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gforse : MonoBehaviour
{
    private float d;
    private float G = 3;

    private Vector3 r;
    private Vector3 start_impulse;

    private float mass1;
    private float mass2 = 10f;

    void Start()
    {

        mass1 = GetComponent<Rigidbody>().mass;

        start_impulse = new Vector3(-2, 2, 0);
        GetComponent<Rigidbody>().AddForce(start_impulse, ForceMode.Impulse);
    }

   
    void Update()
    {
        r = transform.position;
        d = r.magnitude;
        r.Normalize();

        GetComponent<Rigidbody>().AddForce(-r * mass1 * mass2 * G / (d * d));

    }
}
