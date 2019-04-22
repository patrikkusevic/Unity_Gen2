using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RB_7Zad : MonoBehaviour
{
    //Zadatak 7. Napišite skriptu za silu eksplozije
    /* Objašnjenje koda i kako on funkcionira:
    public void AddExplosionForce
    (float explosionForce, -> Sila explozije koja se može modificirati po udaljenosti
    Vector3 explosionPosition, -> Pozicija eksplozije označava sredinu (0,0,0) poziciju unutar Sphere u kojoj sila ima učinka
    float explosionRadius, -> Radijus eksplozije je radijus Sphere kako bih se odredilo unutar čega sila ima učinka
    float upwardsModifier = 0.0f, -> Podešavanje pozicije ekslozije da pruži efekt podizanja objekata u zrak na koje djeluje
    ForceMode mode = ForceMode.Force)); -> Metoda koja se koristi kako bih se primjenila sila na objekte unutar sfere
    */

    public float Radijus = 5.0F;
    public float Jacina = 10.0F;

    void Start()
    {
        Vector3 expl_Pos = transform.position; //Dodjeljujemo centralnu poziciju sfere
        Collider[] colliders = Physics.OverlapSphere(expl_Pos, Radijus); //Dodjeljujemo fiziku na nepostojecu sferu koju ujedno i stvaramo uz pomoc Physic i dajemo joj poziciju i radijus
        foreach (Collider hit in colliders) //Foreach služi, kao i prevedeno Za svaki nešto učini nešto, za svaki udar u collider napravi exploziju
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(Jacina, expl_Pos, Radijus, 3.0F);
        }
    }
}
