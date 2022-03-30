using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class EndScreen : MonoBehaviour
{
    public UnityEngine.UI.Text winOrLooseText;
    public GameObject screen;

    public void WinScreen()
    {
        winOrLooseText.text = "You Win";
        screen.SetActive(true);

        for (int i = 0; i < screen.transform.childCount; i++)
        {
            screen.transform.GetChild(i).gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void LooseScreen()
    {
        winOrLooseText.text = "You Loose";
        screen.SetActive(true);

        for (int i = 0; i < screen.transform.childCount; i++)
        {
            screen.transform.GetChild(i).gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void QuitGame()
    {
        Time.timeScale = 1;
        Application.Quit();
    }
    
    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
