using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutPointage : MonoBehaviour
{

// Références vers les objets de la scène que l’on veut activer/désactiver
    [SerializeField] GameObject zoneTrigger;    // Zone qui détecte le joueur
    [SerializeField] GameObject lumiereBleu;    // Lumière bleue à activer lors du succès
    [SerializeField] GameObject lumiereRouge;   // Lumière rouge à désactiver lors du succès

// Référence vers le GameManager (gère les points et la logique du jeu)
   private GameManager gameManager;


private void Awake()
    {
        // On cherche automatiquement le GameManager dans la scène
        // FindObjectOfType renvoie le premier composant GameManager trouvé
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

// Cette fonction est appelée automatiquement quand un autre objet avec un Collider entre dans la zone de ce GameObject
   public void OnTriggerEnter(Collider other)
{
    // On vérifie si l’objet qui entre dans la zone a le tag "Player"
    if (other.CompareTag("Player")){

    // On ajoute un point au score via le GameManager
      gameManager.AjoutPoints();

    // On désactive la zone de détection pour éviter plusieurs activations
      zoneTrigger.SetActive(false);

    // On éteint la lumière rouge
      lumiereRouge.SetActive(false);

    // On allume la lumière bleue pour indiquer que la zone a été validée
      lumiereBleu.SetActive(true);
    }
}
}
