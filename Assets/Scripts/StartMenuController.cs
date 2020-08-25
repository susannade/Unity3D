using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    public void Play()
    {
    //    SceneManager.CreateScene("SampleScene");
        SceneManager.LoadScene("SampleScene");
    }
    public void End()
    {
        Application.Quit();
    }
}
