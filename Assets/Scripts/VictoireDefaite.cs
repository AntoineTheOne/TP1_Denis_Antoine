using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; // Nécessaire pour charger des scènes
using UnityEngine;

public class VictoireDefaite : MonoBehaviour
{
    // Objets de la scène que le script va activer ou désactiver
    [SerializeField] GameObject zoneTrigger;    // Zone de détection pour le joueur
    [SerializeField] GameObject lumiereBleu;    // Lumière bleue (victoire de la zone)
    [SerializeField] GameObject lumiereRouge;   // Lumière rouge (avant succès)
    // Référence au GameManager (pour accéder au pointage)
    private GameManager gameManager;
    // Variable locale pour stocker temporairement le score du joueur
    private int valeur;
    void Start()
    {
        // Trouve automatiquement le GameManager dans la scène
        gameManager = FindObjectOfType<GameManager>();
        // Initialise la valeur du score au démarrage
        MettreAJourValeur();
    }
// Détecte quand le joueur entre dans la zone associée à cet objet
    private void OnTriggerEnter(Collider other)
    {
        // On vérifie que c’est bien le joueur
        if (other.CompareTag("Player"))
        {
            // On ajoute un point grâce au GameManager
            gameManager.AjoutPoints();
            // On désactive la zone pour éviter plusieurs activations
            zoneTrigger.SetActive(false);
            // On éteint la lumière rouge
            lumiereRouge.SetActive(false);
            // On allume la lumière bleue (zone complétée)
            lumiereBleu.SetActive(true);

            // On vérifie maintenant si la partie est gagnée ou perdue
            VictoireOuDefaite();
        }
    }
    // Met à jour la variable locale "valeur" avec le score actuel du GameManager
    public void MettreAJourValeur()
    {
        valeur = gameManager.pointage;
    }
    // Vérifie la condition de victoire ou de défaite
    public void VictoireOuDefaite()
    {
        // Actualise le score avant vérification
        MettreAJourValeur();
        // Si le joueur a atteint ou dépassé 6 points → victoire
        if (valeur >= 6)
        {
            ChangementScene("SceneFinReussi");
        }
        // Si le joueur a 5 points ou moins → échec
        else if (valeur <= 5)
        {
            ChangementScene("SceneFinEchec");
        }
    }
    // Fonction utilitaire pour changer de scène
    public void ChangementScene(string _nomScene)
    {
        SceneManager.LoadScene(_nomScene);
    }
}