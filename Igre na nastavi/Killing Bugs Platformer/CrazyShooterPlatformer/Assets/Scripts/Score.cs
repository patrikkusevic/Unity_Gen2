using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score_text;
    public int score_count = 0;

    void Start()
    {
        score_text.text = "Score: " + score_count;
    }

    void Update()
    {
        score_text.text = "Score: " + score_count;
    }
}
