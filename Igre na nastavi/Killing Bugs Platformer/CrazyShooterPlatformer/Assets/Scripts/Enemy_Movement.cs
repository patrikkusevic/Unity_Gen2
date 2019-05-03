using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement : MonoBehaviour
{
    public GameObject player;
    PlayerHealth playerHealth;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //Nadi kad se stvori playera na sceni
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.5f);
    }

    void OnCollisionEnter(Collision other) //Nije on trigger zbog metka
    {
        if(other.gameObject.tag == "Player") //Ako udari u lika
        {
            playerHealth.current_health -= Random.RandomRange(5, 20);
            playerHealth.rec = false;
            Destroy(this.gameObject);
        }
    }
}
