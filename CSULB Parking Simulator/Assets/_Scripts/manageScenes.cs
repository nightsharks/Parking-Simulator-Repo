using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manageScenes : MonoBehaviour {

    public void startClick()
    {
        SceneManager.LoadScene(sceneName: "MainLevel");
    }

    public void quitClick()
    {
        Application.Quit();
    }

    public void returnClick()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }
}
