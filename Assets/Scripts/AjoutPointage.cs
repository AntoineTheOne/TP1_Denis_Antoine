using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjoutPointage : MonoBehaviour
{

   [SerializeField] GameObject zoneTrigger;
   [SerializeField] GameObject lumiereBleu;
   [SerializeField] GameObject lumiereRouge;
   private GameManager gameManager;


private void Awake()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

   public void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Player")){
      gameManager.AjoutPoints();
      zoneTrigger.SetActive(false);
      lumiereRouge.SetActive(false);
      lumiereBleu.SetActive(true);
    }
}
}
