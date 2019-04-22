using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mono_2zad : MonoBehaviour
{
    //Zadatak 2. Glavne funkcije MonoBehavioura su:
    /* 
    Awake() - Poziva se na početku prvog framea scene i poziva se samo jednom, neovisno o tome jel skripta aktivna ili ne
    Start() - Isto kao i Awake, ali ako je skripta neaktivna on se ne poziva
    Update() - Poziva se svaki frame, pripaziti malo da stvari koje trebaju ići u start ne pišete u update
    FixedUpdate() - Poziva se svaki fixni frame, FixedUpdate se treba koristiti kada radite s Rigidbodyem jer npr. kada koristie silu na RIgidbody zelite da se ta sila izvrsi do kraja, a ne da se ucita sljedeci frame i opet krene sila ispocetka
    LateUpdate() - Poziva se svaki Frame, ali tek nakon što se izvrti sve potrebno u Updateu. Npr. kod koji prati lika je u LateUpdate(), a pokret lika u Update, vidjet će se lijepa tranzicija
    OnGUI() - Poziva se kada se koristi renderiranje i upravljanje GUI naredbama. Može biti pozvan i nekoliko puta u jednom frameu, ovisno o "eventu".
    OnDisable() - Poziva se kada skripta postane neaktivna. Korisna je ako se neki objekt uništi i da njegova skripta (Npr, enemy AI je umor) ne radi u pozadini iskorsti se OnDisable kako bi unistio pozadinski rad unistenog objekta
    OnEnable() - Poziva se kada objekt postane aktivan
    */
}
