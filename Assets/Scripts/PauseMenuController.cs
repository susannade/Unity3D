using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject Menu;
    public GameObject HUD;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("isworkin");
        if (Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("pressedpasuelosdkfoskgog");
            if (PlayerContoller.gameStatus == 0)
            {
                ResumeGamePlease();
            }
            else
            {
                PauseGamePlease();
            }

        }
    }
    public void ResumeGamePlease()
    {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        HUD.SetActive(true);
        PlayerContoller.gameStatus = 1;
    }
    void PauseGamePlease()
    {
        HUD.SetActive(false);
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Menu.SetActive(true);
        PlayerContoller.gameStatus = 0;

    }
    public void MenuButton()
    {
        SceneManager.LoadScene("StartMenu");
     //   SceneManager.UnloadSceneAsync("SampleScene");
        Time.timeScale = 1f;
        PlayerContoller.gameStatus = 1;
        PlayerContoller.health = 3;
     //   SceneManager.CreateScene("StartMenu");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
