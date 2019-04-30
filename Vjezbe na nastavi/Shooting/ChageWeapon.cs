using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChageWeapon : MonoBehaviour
{
    public GameObject gun;
    public GameObject kalas;

    void Start()
    {
        gun.SetActive(true);
        kalas.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            gun.SetActive(true);
            kalas.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            gun.SetActive(false);
            kalas.SetActive(true);
        }
    }
}
