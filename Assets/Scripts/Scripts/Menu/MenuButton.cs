using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    
    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }
    public void ButtonMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Levels()
    {
        SceneManager.LoadScene(5);
    }
    public void LevelsSecond()
    {
        SceneManager.LoadScene(2);
    }
    public void LevelsSeconds()
    {
        SceneManager.LoadScene(3);
    }
}
