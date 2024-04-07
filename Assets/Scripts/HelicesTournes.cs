using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicesTournes : MonoBehaviour
{
    public float vitesseRotation = 1000f;

    void Update()
    {
        float angleRotation = vitesseRotation * Time.deltaTime;
        transform.Rotate(Vector3.right, angleRotation);
    }
}
