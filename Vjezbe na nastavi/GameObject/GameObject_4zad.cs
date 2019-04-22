using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_4zad : MonoBehaviour
{
    //Zadatak 4. Neka kocka postaje aktivna i neaktivna na svaki frame. Kako to utjece na FPS?
    private bool active;
    public GameObject Objekt;
    void Update()
    {
        if(active == false)
        {
            Objekt.SetActive(false);
            active = true;
        }
        else
        {
            Objekt.SetActive(true);
            active = false;
        }
    }
}
