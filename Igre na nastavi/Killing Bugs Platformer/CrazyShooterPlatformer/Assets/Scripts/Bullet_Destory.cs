using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destory : MonoBehaviour
{
    public float vrijeme_destroy = 5.5f;
    Score score;

    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    void Update()
    {
        vrijeme_destroy -= Time.deltaTime;
        if(vrijeme_destroy <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            score.score_count++;
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject);
    }
}
