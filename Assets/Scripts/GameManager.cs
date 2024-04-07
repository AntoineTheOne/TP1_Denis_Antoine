using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int pointage = 0;

    public void AjoutPoints()
    {
        pointage++;
        Debug.Log("tu est maintenant à " + pointage);
    }
}
