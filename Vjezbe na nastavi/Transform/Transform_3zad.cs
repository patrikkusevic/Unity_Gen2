using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform_3zad : MonoBehaviour
{
    //3. zadatak: Napravite skriptu da se kocka povećava ili smanjuje (do maksimalno 10) po sve 3 osi i rotira po sve 3 osi uz public varijable
    public float RS_X; //RS = Rotate Speed
    public float RS_Y;
    public float RS_Z;

    public float SS_X; //SS = Scale size
    public float SS_Y;
    public float SS_Z;
    private float x1;
    private float y1;
    private float z1;


    void Update()
    {
        // dodjeljivanje x,y,z scale na varijable
        x1 = transform.localScale.x;
        y1 = transform.localScale.y;
        z1 = transform.localScale.z;
        // scale do maksimalno 10
        if (x1 <= 10 && y1 <= 10 && z1 <= 10)
        {
            transform.localScale += new Vector3(SS_X, SS_Y, SS_Z);
        }
        transform.Rotate(Vector3.right * RS_X);
        transform.Rotate(Vector3.up * RS_Y);
        transform.Rotate(Vector3.forward * RS_Z);
    }
}
