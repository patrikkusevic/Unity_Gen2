using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mono_3zad : MonoBehaviour
{
    //Zadatak 3. Napišite skriptu koja će imati Debug na:
    // a. Awake
    // b. Start
    // c. Update (update dio teksta u boji)
    void Awake() //Rj: a, awake se poziva neovisno o tome jeli skripta aktivna ili nije
    {
        Debug.Log("Ovo je Awejk");
    }
    void Start() // Rj: b
    {
        Debug.Log("Ovo je start");
    }
    void Update() //Rj: c
    {
        Debug.Log("<color=green> Napomena: </color> Updatejt radi");
    }
}
