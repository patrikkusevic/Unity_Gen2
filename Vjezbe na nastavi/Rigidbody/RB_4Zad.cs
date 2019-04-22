using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_4Zad : MonoBehaviour
{
    //Zadatak 4. Napišite skriptu za uključiti/iskljuciti gravitaciju na Rigidbodyu.
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GravityByeBye();
    }

    void GravityByeBye()
    {
        rb.useGravity = false;
    }
}
