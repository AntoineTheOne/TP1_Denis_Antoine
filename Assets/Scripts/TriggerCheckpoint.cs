using UnityEngine;

public class TriggerCheckpoint : MonoBehaviour
{
    [SerializeField] private GameObject zoneTouche;

    private void OnTriggerEnter(Collider other){
        Debug.Log("Tout Fonctionne ici!!!");
    if (other.tag == "Player")
    {
        zoneTouche.SetActive(false);
        Debug.Log("Tout Fonctionne ici!!!");
    }
}
}
