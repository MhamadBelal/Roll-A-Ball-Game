using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Slider slider;
    public void MenuGame()
    {
        SceneManager.LoadScene(1);
    }
    public void BackGo()
    {
        SceneManager.LoadScene(0);
    }
    public void Slider()
    {
        print(slider.value);
    }
}
