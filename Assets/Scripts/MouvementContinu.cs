using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementContinu : MonoBehaviour
{
    [SerializeField] float vitesse = 5f; 

    void Update()
    {
        transform.Translate(Vector3.forward * vitesse * Time.deltaTime);
    }
}
