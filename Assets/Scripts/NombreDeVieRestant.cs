using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NombreDeVieRestant : MonoBehaviour
{

    public int NbDeVieRestant = 3;




private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Roche"))
        {
            NbDeVieRestant--;
            Debug.Log("Je n'ai plus que" + NbDeVieRestant);
        }
    }
    void Update(){
        if(NbDeVieRestant <= 0){
            ChangementScene("SceneFinEchec");
        }
    }




    public void ChangementScene(string _nomScene){
        SceneManager.LoadScene(_nomScene);
    }
}
