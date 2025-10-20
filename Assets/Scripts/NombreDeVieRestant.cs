using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // Nécessaire pour changer de scène
using UnityEngine;

public class NombreDeVieRestant : MonoBehaviour
{
    // Nombre de vies restantes pour le joueur
    public int NbDeVieRestant = 3;



// Détecte les collisions physiques avec ce GameObject
private void OnCollisionEnter(Collision collision){

        // Si on touche un objet qui a le tag "Roche"
        if (collision.gameObject.CompareTag("Roche"))
        {
            // On retire une vie
            NbDeVieRestant--;

            // Affiche dans la console le nombre de vies restantes
            Debug.Log("Je n'ai plus que" + NbDeVieRestant);
        }
    }

    // Update est appelé à chaque frame
    void Update(){

        // Si plus aucune vie → on passe à la scène d’échec
        if(NbDeVieRestant <= 0){
            ChangementScene("SceneFinEchec");
        }
    }



    // Fonction pour changer de scène
    public void ChangementScene(string _nomScene){
        SceneManager.LoadScene(_nomScene);
    }
}
