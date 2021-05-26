using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D collided)
    {
        // Appelle le ralentissement de la voiture
        if (collided.name == "VoitureJoueur")
        {
            Debug.Log("Ralentissement");
            // VoitureJoueur voiture = collided.GetComponent<VoitureJoueur>();
            // voiture.Ralentissement();
        }

    }
}
