using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mix_2Zad : MonoBehaviour
{
    // 2. zadatak. Napravite skriptu za otvaranje vrata
    // a. Vrata se otvaraju na gumb "F", a ako su vrata otvorena onda se na "F" zatvaraju
    // b. Neka se "F" može stisnuti samo kad je lik kod vrata
    float MaxVrata = 0; // rotacija vrata trenutna
    float y_End; // Maksimalna rotacija 
    bool B_Vrata; //Dal se vrata otvaraju ili zatvaraju
    float y_Start; //početna rotacija objekta po Y osi

    void Start()
    {
        y_End = transform.localEulerAngles.y + 90.0f; //Konacna rotacija vrata (pocetna GameObject Y rotation + 90°)
        y_Start = transform.localEulerAngles.y; //Pocenta game object Y rotation
    }
    void Update()
    {
        if (MaxVrata <= y_End && B_Vrata == true) //Rj: a
        {
            transform.Rotate(Vector3.up * 1.5f);
            MaxVrata = transform.localEulerAngles.y;
        }
        else if (MaxVrata >= y_Start && B_Vrata == false) // Rj: a
        {
            transform.Rotate(Vector3.down * 1.5f);
            MaxVrata = transform.localEulerAngles.y;
        }
    }

    void OnTriggerStay(Collider other) //OnTriggerStay za razliku od OnTriggerEnter cita kada objekt stoji unutra a ne samo an udar
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.F)) // Rj: b
        {
            if (MaxVrata <= y_Start)
            {
                B_Vrata = true;
            }
            else if (MaxVrata >= y_End)
            {
                B_Vrata = false;
            }
        }
    }
}
