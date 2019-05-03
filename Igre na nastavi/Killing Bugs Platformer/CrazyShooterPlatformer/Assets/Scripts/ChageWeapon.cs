using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChageWeapon : MonoBehaviour
{
    public GameObject gun;
    public GameObject kalas;
    public Shooting shooting;
    int metci;

    void Start()
    {
        gun.SetActive(true);
        kalas.SetActive(false);
        metci = shooting.max_broj_metaka;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            shooting = gun.GetComponent<Shooting>();
            shooting.ammo_text.text = "Sada je metaka: " + shooting.sada_broj_metaka + "/" + metci;
            gun.SetActive(true);
            kalas.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            shooting = kalas.GetComponent<Shooting>();
            shooting.ammo_text.text = "Sada je metaka: " + shooting.sada_broj_metaka + "/" + metci;
            gun.SetActive(false);
            kalas.SetActive(true);
        }
    }
}
