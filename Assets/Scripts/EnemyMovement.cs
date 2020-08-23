using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * speed;
    }
    void OnTriggerEnter(Collider other)
    {
       
        if (other.CompareTag("Wall") || other.CompareTag("Coin"))
        {
           
            transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
        }


    }
    // Update is called once per frame

}
