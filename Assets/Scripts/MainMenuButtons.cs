using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public int PlayGameOnScene;

    public void StartGame() {
        SceneManager.LoadScene(PlayGameOnScene);
    }

    public void QuitGame() {
        Application.Quit();
        Debug.Log("The game has quit.");
    }
}
