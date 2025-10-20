using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireRoche : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        // Invoke() appelle une fonction après un certain délai (ici 20 secondes)
        // Cela signifie que l’objet sera détruit après 20 secondes d’existence
        Invoke("Detruire", 20f);
    }



    private void Detruire(){
        // Supprime complètement ce GameObject de la scène
        Destroy(gameObject);
    }
}
