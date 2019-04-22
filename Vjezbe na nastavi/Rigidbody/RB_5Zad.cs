using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_5Zad : MonoBehaviour
{
    //5. zadatak. Napišite skriptu za silu (add force) da se objekt krece po X osi
    public float brzina;
    public Rigidbody rb; //ponavljam "rb" je pravilna svijetska skraćenica za rigidbody

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() //rekli smo da sa silom i rigidbodyem radimo sa "FixedUpdate" ne sa "Update"
    {
        rb.AddForce(transform.right * brzina);
    }
}
