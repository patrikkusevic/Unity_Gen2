using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 60;
    public Text timer_text;

    void Update()
    {
        timer -= Time.deltaTime;
        timer_text.text = "Left time: " + timer;
        if(timer <= 0)
        {
            Application.Quit();
        }
    }
}
