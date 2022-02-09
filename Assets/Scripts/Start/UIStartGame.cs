using UnityEngine;
using UnityEngine.SceneManagement;

public class UIStartGame : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
