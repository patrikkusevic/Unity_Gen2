using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Destory : MonoBehaviour
{
    public float vrijeme_destroy = 5.5f;
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
        Destroy(other.gameObject);
        Destroy(this.gameObject);
    }
}
