using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prziona : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Application.Quit();
    }
}
