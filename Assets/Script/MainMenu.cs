using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("Mulai");
    }

    public void playQuiz()
    {
        SceneManager.LoadScene("Tentang");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
