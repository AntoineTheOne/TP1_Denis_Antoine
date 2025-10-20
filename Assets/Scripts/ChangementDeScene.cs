using UnityEngine;
using UnityEngine.SceneManagement; // Nécessaire pour utiliser SceneManager

public class ChangementDeScene : MonoBehaviour
{

// Fonction publique appelée depuis d'autres scripts ou un bouton UI
// Le paramètre "_nomScene" contient le nom exact de la scène à charger
    public void ChangementScene(string _nomScene){
        // Charge la scène indiquée dans les paramètres
        SceneManager.LoadScene(_nomScene);
    }
}
