using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript_Main : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 5f;
    public float sprintTime = 5f;
    
    public Rigidbody rb;
    
    public bool jump = false;

    void handleMovement()
    {
        
        // Basic movement
        if (Input.GetKey(KeyCode.W))
        {
            // check for shift key => sprint
            if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.Translate(Vector3.forward * speed * 2 * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!jump)
            {
                jump = true;
                rb.velocity = Vector3.up * jumpForce;
            }
        }
        
    }
    
    void Update()
    {
        handleMovement();
    }
}
