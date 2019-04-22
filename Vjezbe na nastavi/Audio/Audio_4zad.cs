using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_4zad : MonoBehaviour
{
    //Zadatak 4. Na isti objekt iz zadtaka 3. dodajte da se zvuk zaustavi nakon 5 sekundi
    public float brojac;
    public AudioSource zvuk;
    void Update()
    {
        brojac += Time.deltaTime;
    }
    void PokreniZvuk()
    {
        if (brojac >= 5)
        {
            zvuk.Stop(); //Rj
        }
    }
}
