using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

<<<<<<< HEAD:Assets/Scripts/Scene/MainMenu.cs
    public void ReplayGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

=======
>>>>>>> parent of 594c6a3... Semifinal:Assets/MainMenu.cs
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }

}
