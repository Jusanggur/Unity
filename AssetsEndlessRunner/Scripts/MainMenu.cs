using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public string playGameLevel1;
    public string playGameLevel2;

    public void PlayGameLevel1()
    {
        Application.LoadLevel(playGameLevel1);
    }

    public void PlayGameLevel2()
    {
        Application.LoadLevel(playGameLevel2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
