using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HudController : MonoBehaviour
{
    public GameObject Hp;
    public Sprite FullHp;
    public Sprite MidHp;
    public Sprite LowHp;
    public Sprite Dead;
    public Text score;
    public Text stars;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerContoller.health==3){
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
        }
        score.text=PlayerContoller.score.ToString();
        stars.text=PlayerContoller.stars.ToString();

    }
}
