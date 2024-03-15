using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene(2);          //Переход к 1 уровню
    }
    public void Settings()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();         //Выход из программы
    }

}
