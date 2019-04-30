using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    //Kada stisnemo ljevi klik miša, pucamo iz spawn pointa,
    //pucamo metak iz prefaba, brzina, imamo sound kad puknemo

    public Rigidbody metak; //tu dodajemo prefab metka
    public Transform bullet_Spawn; //tu dodajemo empty game object, iji se transform gleda za spawn metka
    public AudioSource zvuk_metka; //tu dodajemo audiosource koji će reproducirati pucanje
    public float brzina_metka = 20;
    public int max_broj_metaka = 15;
    public int sada_broj_metaka = 0;
    public Text ammo_text;
    public float start_fire_rate = 1.5f;
    public float sada_fire_rate = 0;

    void Start()
    {
        sada_broj_metaka = max_broj_metaka;
        sada_fire_rate = start_fire_rate;
        ammo_text.text = "Sada je metaka: " + sada_broj_metaka + "/" + max_broj_metaka;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && sada_broj_metaka > 0 && sada_fire_rate >= start_fire_rate)
        {
            //StartCoroutine(Countdown())
            sada_broj_metaka--;
            ammo_text.text = "Sada je metaka: " + sada_broj_metaka + "/" + max_broj_metaka;
            Rigidbody clone_metak;
            clone_metak = Instantiate(metak, bullet_Spawn.position, bullet_Spawn.rotation);
            clone_metak.velocity = bullet_Spawn.TransformDirection(Vector3.forward * brzina_metka);
            zvuk_metka.Play();
        }

        if(sada_fire_rate<start_fire_rate)
        {
            sada_fire_rate += Time.deltaTime;
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            sada_broj_metaka = max_broj_metaka;
            ammo_text.text = "Sada je metaka: " + sada_broj_metaka + "/" + max_broj_metaka;
        }
    }

    //private IEnumerator Countdown()
    //{
    //    while(sada_fire_rate <= start_fire_rate)
    //    {
    //        sada_fire_rate += Time.deltaTime;
    //        yield return null;
    //    }
    //}
}
