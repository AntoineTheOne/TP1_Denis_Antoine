using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    // Prefab de l’objet à instancier (ici une roche)
    [SerializeField] GameObject rochePrefab;
    // Taille de la zone dans laquelle les roches peuvent apparaître
    [SerializeField] private Vector3 zoneSize;
    // Temps entre chaque apparition d’une roche (en secondes)
    [SerializeField] private float repeatTime = 0.5f;
private void Start(){
// Appelle la fonction AddGameObject de manière répétée :
// - Immédiatement au démarrage (0 seconde)
// - Puis toutes les "repeatTime" secondes
InvokeRepeating("AddGameObject", 0, repeatTime);
}
// Fonction qui crée une nouvelle roche dans la scène
void AddGameObject(){
    // Crée une instance du prefab de roche
    GameObject instantiated = Instantiate(rochePrefab);
        // Définit une position aléatoire dans le volume défini par "zoneSize"
        instantiated.transform.position = new Vector3(
            Random.Range(transform.position.x - zoneSize.x / 2, transform.position.x + zoneSize.x / 2),
            Random.Range(transform.position.x - zoneSize.y / 2, transform.position.x + zoneSize.y / 2),
            Random.Range(transform.position.x - zoneSize.z / 2, transform.position.x + zoneSize.z / 2)
        );
}
// Permet de visualiser la zone de spawn dans la vue "Scene" de l’éditeur Unity
private void OnDrawGizmos() {

    // On choisit la couleur rouge pour la boîte
    Gizmos.color = Color.red;

    // On dessine une boîte filaire correspondant à la taille de la zone
    Gizmos.DrawWireCube(transform.position, zoneSize);
}
}
