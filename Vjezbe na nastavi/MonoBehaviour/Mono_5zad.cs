using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mono_5zad : MonoBehaviour
{
    // 5. zadatak. Napravite uz pomoć "OnTriggerEnter" kod koji će jedan objekt destroyati, a drugi će zarotirati za 45° po Y osi
    public string Tag_Destroy;
    public string Tag_Rotate;

    void OnTriggerEnter(Collider other)
    {
        //ovaj if služi da uništi objekt sa tagom destroy
        if (other.gameObject.tag == Tag_Destroy)
        {
            Destroy(other.gameObject);
        }
        else if (other.gameObject.tag == Tag_Rotate)
        {
            other.transform.Rotate(new Vector3(0, 45f, 0));
        }
    }
}
