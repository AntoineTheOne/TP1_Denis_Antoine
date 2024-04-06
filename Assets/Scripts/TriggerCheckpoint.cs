using UnityEngine;

public class TriggerCheckpoint : MonoBehaviour
{


[SerializeField] private GameObject zoneTrigger;

public float score = 0;

private void OnTriggerEnter(Collider other) {
    
    if(other.CompareTag("Player")){
        zoneTrigger.SetActive(false);
        score++;
        Debug.Log(score);
    }

}



}
