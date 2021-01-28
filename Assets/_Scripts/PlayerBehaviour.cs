using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float movementForce;
    public Rigidbody rigidBody;
    public float jumpForce;
    public bool isGrounded;


    void Start()
    {
       rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGrounded)
        {
            if (Input.GetAxisRaw("Horizontal") > 0)
            {
                //move left
                rigidBody.AddForce(Vector3.right * movementForce);
            }

            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                //move right
                rigidBody.AddForce(Vector3.left * movementForce);
            }

            if (Input.GetAxisRaw("Vertical") > 0)
            {
                //move left
                rigidBody.AddForce(Vector3.forward * movementForce);
            }

            if (Input.GetAxisRaw("Vertical") < 0)
            {
                //move right
                rigidBody.AddForce(Vector3.down * movementForce);
            }
            if (Input.GetAxisRaw("Jump") > 0)
            {
                rigidBody.AddForce(Vector3.up * jumpForce);
            }
        } 
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
