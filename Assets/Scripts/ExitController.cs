
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitController : MonoBehaviour
{
    public void ExitGame()
    {
        SceneManager.LoadSceneAsync("Scenes/Main");
    }
}
