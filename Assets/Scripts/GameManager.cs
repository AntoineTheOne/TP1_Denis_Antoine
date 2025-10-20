using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    // Variable publique qui stocke le nombre de points du joueur
    public int pointage = 0;


    // Fonction appelée quand on veut ajouter un point au joueur
    public void AjoutPoints()
    {

        // On incrémente le score
        pointage++;

        // On affiche le nouveau score dans la console Unity (utile pour déboguer)
        Debug.Log("tu est maintenant à " + pointage);
    }
}
