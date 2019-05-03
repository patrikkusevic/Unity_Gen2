using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public float current_health;
    public bool rec = true;
    public Slider health_slider;
    float time_to_rec = 0; //vrijem potrebno da se počne puniti health

    void Start()
    {
        current_health = health;
    }

    void Update()
    {
        health_slider.value = current_health/100;

        //REGENERACIJA!

        //if(rec == true && current_health <= 99)
        //{
        //    current_health += 0.01f;
        //}
        //else if(rec == false)
        //{
        //    float count = 0;
        //    while(count < 5)
        //    {
        //        count += Time.deltaTime;
        //    }
        //    if(count > 5)
        //    {
        //        rec = true;
        //    }
        //}


        if(current_health <= 0)
        {
            Destroy(this.gameObject); //Restartaj scenu
            Application.Quit();
        }
    }
}
