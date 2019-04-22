using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_2zad : MonoBehaviour
{
    //Napravite objekt na kojem će se puštati zvuk za pozadinu
    //a. Tko je listener? - Rj: Kamera
    //b. Nama se zvuk čuje na loopu cijelo vrijeme // Rj: Na AudioSource komponenti staviti "Loop" na true
    //c. Neka se zvuk čuje samo jednom
    public AudioSource zvuk;
    public AudioClip Klip; //potrebno za C zadatak
    void Start()
    {
        zvuk.Play(); //2. zad
        zvuk.PlayOneShot(Klip, 0.4f);//Rj: c
    }

}
