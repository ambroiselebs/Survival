using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript_Head : MonoBehaviour
{
    public float sensitivity = 5f;
    public Transform playerBody;
    
    void Update()
    {
        float rotateX = Input.GetAxis("Mouse X");
        playerBody.transform.RotateAround(playerBody.transform.position, -Vector3.up, rotateX*sensitivity);
        
        float rotateY = Input.GetAxis("Mouse Y");
        transform.RotateAround(transform.position, transform.right, rotateY*sensitivity);
    }
}
