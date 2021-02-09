using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour{
    public void LoadNextScene() {
        //gets the index of the current running scene
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //adds plus 1 to the current scene index
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void loadStartScene() {
        SceneManager.LoadScene(0);
    }

    public void loadGameplayScene() {
        SceneManager.LoadScene(1);
    }

    public void quitApplication() {
        Application.Quit();
    }
}
