using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonDirecter : MonoBehaviour
{
    public void MiniGame()
    {
        SceneManager.LoadScene("Mini Game");
    }
    public void ClearScreen()
    {
        SceneManager.LoadScene("Clear Screen");
    }
    public void StartMenu()
    {
        SceneManager.LoadScene("Start Menu");
    }
}