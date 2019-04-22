using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mix_3Zad : MonoBehaviour
{
    //Skripta za micanje lika (first person), koristite horizontal i vertical
    // a. Na W ide naprijed u smjeru kamere (gdje kamera gleda)
    // b. Na S ide nazad
    // c. Na A ide lijevo, a na D ide desno 
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f; // Rj: a b c
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f; // RJ: a b c
        float jump = Time.deltaTime * 100F;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        if(Input.GetKey(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift)) // Trčanje
        {
            transform.Translate(0, 0, z * 3);
        }
        else if (Input.GetKeyDown(KeyCode.Space)) // Zadatak 5. skakanje
        {
            rb.AddForce(transform.up * 100f);
        }
    }
}