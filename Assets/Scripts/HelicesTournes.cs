using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicesTournes : MonoBehaviour
{
    public float vitesseRotation = 1000f;

    void Update()
    {
        
        // On calcule l’angle à faire tourner depuis la dernière frame
        // Time.deltaTime correspond au temps écoulé depuis la dernière frame
        float angleRotation = vitesseRotation * Time.deltaTime;

        // On applique la rotation autour de l’axe X de l’objet
        // Vector3.right correspond à (1,0,0)
        transform.Rotate(Vector3.right, angleRotation);
    }
}
