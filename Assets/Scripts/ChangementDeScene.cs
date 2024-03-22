using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementDeScene : MonoBehaviour
{








    public void ChangementScene(string _nomScene){
        SceneManager.LoadScene(_nomScene);
    }
}
