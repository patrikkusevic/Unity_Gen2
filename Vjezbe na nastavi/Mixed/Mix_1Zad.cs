using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mix_1Zad : MonoBehaviour
{
    // 1. zadatak: Napravite skriptu:
    // a. Kocka se kreće po Z osi za brzinu po vašem izboru
    // b. Kada kocka udari u sferu(kuglu) počne se kretati za duplu brzinu od početne iskljućivo po Y osi
    // c. Nakon udara sfera počinje reproducirati zvuk po izboru
    // d. Kocka se nakon udara rotira po X osi svaki frame
    public float brzina;
    public Rigidbody rb;
    bool Rotacija;
    public float R_X;
    public AudioSource zvuk; //povucite audioSource sa Sfere

    void Update()
    {
        if (Rotacija == false)
        {
            rb.AddForce(Vector3.forward * brzina); //Rj: a
        }
        else if (Rotacija == true)
        {
            rb.AddForce(Vector3.up * brzina * 2.0f); //Rj: b
            transform.Rotate(Vector3.right * R_X); //Rj d
        }
    }
    void OnTriggerEnter(Collider other)
    {
        Rotacija = true; //Rj: b
        zvuk.Play(); //Rj: c
    }
}

