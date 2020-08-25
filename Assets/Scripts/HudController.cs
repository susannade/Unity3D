using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;
using UnityEngine.SceneManagement;
using System;

public class HudController : MonoBehaviour
{
    public GameObject Hp;

    public Sprite FullHp;
    public Sprite MidHp;
    public Sprite LowHp;
    public Sprite Dead;
    public Text score;
    public Text stars;
    private System.Timers.Timer aTimer;

    float timeLeft = 5f;
    public GameObject LOVEDUCK;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerContoller.health==3){
            Hp.GetComponent<Image>().sprite=FullHp;
        }
        else if(PlayerContoller.health==2){
            Hp.GetComponent<Image>().sprite=MidHp;
        }
        else if(PlayerContoller.health==1){
            Hp.GetComponent<Image>().sprite=LowHp;
        }
        else{
            Hp.GetComponent<Image>().sprite=Dead;
            LOVEDUCK.transform.position = new Vector3(100,100,100);
            timeLeft -= Time.deltaTime;
            bool czyGraZak = false;
            if ((timeLeft < 0 && timeLeft > -1) && czyGraZak == false)
            {
                SceneManager.LoadScene("StartMenu");
                //   SceneManager.UnloadSceneAsync("SampleScene");
                Time.timeScale = 1f;
                PlayerContoller.gameStatus = 1;
                PlayerContoller.health = 3;

                czyGraZak = true;
            }


        }
        score.text=PlayerContoller.score.ToString();
        stars.text=PlayerContoller.stars.ToString();

    }

}
