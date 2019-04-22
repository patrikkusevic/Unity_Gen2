using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Obavezno dodati

public class GameObject_3zad : MonoBehaviour
{
    //Zadatak 3.
    // a. Kada kocka dotakne capsulu neka se ucita druga scena naziva "scenica"
    // b. Nesmije se koristiti "OnTrigger"

    void OnCollisionEnter(Collision other) // Rj: b
    {
        SceneManager.LoadScene("Scenica"); // Rj: a
    }
}
