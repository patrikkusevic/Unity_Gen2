using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_3zad : MonoBehaviour
{
    // Zadatak 3. Na isti object iz zadatka 2. dodajte da se zvuk:
    // a. zaustavi svakih 5 frameova
    // b. pokrene opet nakon njih 5
    private float brojac;
    public AudioSource zvuk;
    void Update()
    {
        brojac += 1;
    }
    void PokreniZvuk()
    {
        if(brojac >= 5)
        {
            zvuk.Pause(); //Rj: a
        }
        else if(brojac >= 10)
        {
            zvuk.UnPause();//Rj: b
            brojac = 0;
        }
    }
}
