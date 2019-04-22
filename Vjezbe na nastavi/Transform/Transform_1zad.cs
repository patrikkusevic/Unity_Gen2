using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_1zad : MonoBehaviour
{
    // 1. Zadatak: Rotirajte kocku za 1 stupanj svaku sekundu
    //a. Po X osi
    //b. Po Y osi
    //c. Po X i Y osi (Dali se okreće ujedno i po Z osi?) - Odg: Da okreće se i po Z osi

    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime); //Rj: a
        transform.Rotate(Vector3.up * Time.deltaTime); //Rj: b
        //Gornja dva reda su zajedno riješenje c
    }
}
