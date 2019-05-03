using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public Text ult_score;
    public Image back; //pozdainska slika
    public float end_score;
    Score scorer;
    Timer timer;
    PlayerHealth playerHealth;

    void Start()
    {
        scorer = FindObjectOfType<Score>();
        timer = FindObjectOfType<Timer>();
        playerHealth = FindObjectOfType<PlayerHealth>();
        ult_score.gameObject.SetActive(false);
        back.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        end_score = scorer.score_count * timer.timer + playerHealth.current_health;
        if(other.gameObject.tag == "Player")
        {
            ult_score.gameObject.SetActive(true);
            back.gameObject.SetActive(true);
            ult_score.text = "Konacni score je: " + end_score;
        }
    }
}
