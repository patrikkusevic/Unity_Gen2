using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_2zad : MonoBehaviour
{
    //Zadatak 2. Scejlajte kocku za:
    //a. 0.1 po X osi svaki frame
    //b. 3 po Y osi na pokretanju igre (koliko je onda kocka dugačka po Y osi)
    void Start()
    {
        transform.localScale += new Vector3(0, 3, 0); //Rj: b. Veličina Y je 4, ali može biti 3 ako se napiše = umijesto +=
    }
    void Update()
    {
        transform.localScale += new Vector3(0.1f, 0, 0); //Rj: a
    }
}
