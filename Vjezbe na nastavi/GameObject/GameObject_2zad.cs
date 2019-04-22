using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_2zad : MonoBehaviour
{
    //Zadatak 2. Postavite kocku na layer 2, a sferu na layer 7
    //Rj: Na inspectoru dodatje layer 7.
    public GameObject kocka;
    public GameObject sfera;
    void Layeric()
    {
        kocka.layer = 2;
        sfera.layer = 7;
    }
    void Start()
    {
        Layeric();
    }
}
