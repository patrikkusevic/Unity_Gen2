using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickHealth : MonoBehaviour
{
    public GameObject pickup;
    float vrijednost_pickupa = 0;
    PlayerHealth playerHealth;
    AudioSource zvuk;

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        vrijednost_pickupa = Random.RandomRange(-10, 10);
        zvuk = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Rotate(0, 2, 0);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            zvuk.Play();
            playerHealth.current_health += vrijednost_pickupa;
            Destroy(this.gameObject);
            
        }
    }
}
