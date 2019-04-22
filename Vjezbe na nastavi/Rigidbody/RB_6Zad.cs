using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_6Zad : MonoBehaviour
{
    //Zadatak 6. zaključajte rotaciju po Z osi. (Na isti način se freeza i pozicija, a sa znakom | možete staviti više freezova odjedanput)
    public Rigidbody rb;
    void Start()
    {
        rb.constraints = RigidbodyConstraints.FreezeRotationZ;
    }
}
