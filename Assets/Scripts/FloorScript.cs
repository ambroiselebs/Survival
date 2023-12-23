using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorScript : MonoBehaviour
{
    public PlayerScript_Main playerScriptMain;
    
    private void Start()
    {
        playerScriptMain = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript_Main>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (playerScriptMain.jump && other.gameObject.name == "PLAYER")
        {
            playerScriptMain.jump = false;
        }
    }
}
