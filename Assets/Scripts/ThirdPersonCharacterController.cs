using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class ThirdPersonCharacterController : MonoBehaviour
{

    public float Speed;
    public Rigidbody rb;
    public bool isGrounded;
    Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        playerMovement();    
    }

    void playerMovement()
    {
        //float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(0, 0f, ver) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

        if (Input.GetKey("up"))
        {
            anim.SetInteger("condition", 1);
        }
        if (Input.GetKeyUp("up"))
        {
            anim.SetInteger("condition", 0);
        }
        if (Input.GetKey("down"))
        {
            anim.SetInteger("condition", 1);
        }
        if (Input.GetKeyUp("down"))
        {
            anim.SetInteger("condition", 0);
        }
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(new Vector3(0, 5, 0), ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
