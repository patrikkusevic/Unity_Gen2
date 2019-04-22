using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mono_4zad : MonoBehaviour
{
    //Zadatak 4. Napravite "OnTriggerEnter" skriptu koja destroya objekt
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
