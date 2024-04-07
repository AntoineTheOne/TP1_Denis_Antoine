using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class VictoireDefaite : MonoBehaviour
{
    [SerializeField] GameObject zoneTrigger;
    [SerializeField] GameObject lumiereBleu;
    [SerializeField] GameObject lumiereRouge;
    private GameManager gameManager;
    private int valeur;

    void Start()
    {
        // Récupérer le GameManager au démarrage
        gameManager = FindObjectOfType<GameManager>();
        // Mettre à jour la valeur initiale du pointage
        valeur = gameManager.pointage;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            gameManager.AjoutPoints();
          
            valeur = gameManager.pointage;
          
            zoneTrigger.SetActive(false);
            lumiereRouge.SetActive(false);
            lumiereBleu.SetActive(true);
         
            VictoireOuDefaite();
        }
    }

    public void VictoireOuDefaite()
    {
        if (valeur >= 6)
        {
            ChangementScene("SceneFinReussi");
        }
        else if (valeur <= 5)
        {
            ChangementScene("SceneFinEchec");
        }
    }

    public void ChangementScene(string _nomScene)
    {
        SceneManager.LoadScene(_nomScene);
    }
}
