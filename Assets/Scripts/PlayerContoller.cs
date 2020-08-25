using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    public static int score = 0;
    public static int stars = 0;
    public static int health = 3;
    public static int gameStatus = 1; //0-stop 1-run 2-?

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score++;
            Debug.Log("Score: " + score);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Star"))
        {
            stars++;
            Debug.Log("Stars: " + stars);
            other.gameObject.SetActive(false);
        }
        if (other.CompareTag("Enemy"))
        {
            health--;
            Debug.Log("Health: " + health);
        }
        if (other.CompareTag("Cat") && stars == 3)
        {
            Debug.Log("You won");
        }
        if (other.CompareTag("Cat") && stars != 3)
        {
            Debug.Log("You need to more stars");
        }

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
