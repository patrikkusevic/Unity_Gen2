using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mono_6zad : MonoBehaviour
{
    //Napišite skriptu koja će:
    // a. na klik "space" povećati kocku po Y i Y osi za veličinu X osi
    // b. na klik "space" pokrenuti zvuk u pozadini
    // c. Z i Y imaju maksilamnu veličinu 20
    // d. ako jedan od Z ili Y osi dođe do 20, zaključava se povećavanje na space
    // e. Neka na svaki void bude napisan debug
    // f. Neka postoji "OnTriggerEnter" sa nekim drugim objektom nakon cega ce se destroyati
    private float x1; //x,y,z 1 si pozivaju vrijednosti X,Y,Z scalea. Moglo se riješiti i bez toga, ali je nepreglednije
    private float y1;
    private float z1;

    public AudioSource zvuk;

    void Update()
    {
        Debug.Log("Učitao se update");
        x1 = transform.localScale.x;
        y1 = transform.localScale.y;
        z1 = transform.localScale.z;
        if (Input.GetKeyDown(KeyCode.Space) && z1 + x1 <= 20 && y1 + x1 <= 20) // može i "if(Input.GetKeyDown("space"))"
        {
            transform.localScale += new Vector3(0, x1, x1); // Rj: a
            zvuk.Play(); // Rj: b
            Debug.Log("Povećavanje Y i Z za veličinu: " + x1 + " X");
        }
        else if (Input.GetKeyDown(KeyCode.Space) && z1 + x1 > 20 && y1 < z1) //ako će biti Z veći od 20 onda neka Z automatski postane 20, a y se uveća za koliko i Z
        {
            float S = 20.0f - z1;
            transform.localScale = new Vector3(x1, y1 + S, 20.0f); //Rj:c && d
            Debug.Log("Povećava se Z na maksimum");
        }
        else if (Input.GetKeyDown(KeyCode.Space) && y1 + x1 > 20 && z1 < y1)//ako će biti Y veći od 20 onda neka Y automatski postane 20, a Z se uveća za koliko i Y
        {
            float S = 20.0f - y1;
            transform.localScale = new Vector3(x1, 20.0f, z1 + S); // Rj:c && d
            Debug.Log("Povećava se Y na maksimum");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //Rj: f
        Debug.Log("Ako udari drugi objekt, uništi drugi objekt");
    }
}
