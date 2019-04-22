using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject_5zad : MonoBehaviour
{
    //Zadatak 5. Napravite 3 empty gameobjecta koje cete nazvati "respawnPoint". Kada se kocka unisti jer dotakne capsulu neka se radnom spawna na jednom od "respawnPointa"
    // var je varijabla koja služi samo u metodi i vrijedi umjesto bilo koje varijeble, float, int, gameobject, vector3 itd.
    public GameObject objekt;
    public GameObject[] spawnPoints;  // [] predstavljaju preznu listu objekata
    Vector3 positioner;
    Vector3 rotationer;
    void Start()
    {
        var r = Random.Range(0, 2); //random
        spawnPoints = GameObject.FindGameObjectsWithTag("spawnPoint"); //punjenje liste
        var positioner = spawnPoints[r].transform.position;
    }
    void Update()
    {
        if (objekt == false)
        {
            Instantiate(objekt, positioner, Quaternion.identity);
        }
    }

}
