using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //Knapptryck öppnar scene
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(0);
    }

    //Quits game
    public void QuitGame()
    {
        Application.Quit();
    }
}
