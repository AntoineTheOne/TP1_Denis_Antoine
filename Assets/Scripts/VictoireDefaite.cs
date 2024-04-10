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
        gameManager = FindObjectOfType<GameManager>();
        MettreAJourValeur();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.AjoutPoints();

            zoneTrigger.SetActive(false);
            lumiereRouge.SetActive(false);
            lumiereBleu.SetActive(true);

            VictoireOuDefaite();
        }
    }

    public void MettreAJourValeur()
    {
        valeur = gameManager.pointage;
    }

    public void VictoireOuDefaite()
    {
        MettreAJourValeur();
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