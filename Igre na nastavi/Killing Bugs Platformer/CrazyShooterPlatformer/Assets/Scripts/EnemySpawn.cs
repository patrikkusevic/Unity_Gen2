using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] spawnpoints;
    float interval = 1.5f;
    int count = 0; //brojimo kolko ih je stvoreno
    int Spawen_Num; // Broj spawn pointova

    void Start()
    {
        Spawen_Num = spawnpoints.Length;
    }

    void Update()
    {
        interval -= Time.deltaTime;
        if(interval <= 0)
        {
            int spawn_number = Random.RandomRange(0, Spawen_Num);
            Instantiate(enemy, spawnpoints[spawn_number].position, spawnpoints[spawn_number].rotation);
            interval = 1.5f;
        }
    }
}
