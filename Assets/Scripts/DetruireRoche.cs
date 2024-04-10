using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetruireRoche : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Detruire", 20f);
    }

    private void Detruire(){
        Destroy(gameObject);
    }
}
