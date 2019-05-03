using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatformDown : MonoBehaviour
{ 
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            rb.useGravity = true;
        }
    }
}
