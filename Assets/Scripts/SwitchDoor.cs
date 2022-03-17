using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class SwitchDoor : MonoBehaviour
{

    bool playerinrange = false;
    void Start()
    {
        
    }

    
    public void playerdetected(bool playerstatus)
    {
        playerinrange = playerstatus;
    }
    public void playeroutofrange(bool playerstatus)
    {
        playerinrange = playerstatus;
    }

    void Update()
    {
        if(playerinrange==true)
        {
            CheckDoorOpen();
        }
    }

    private void CheckDoorOpen()
    {
        if(CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            GetComponent<Animator>().SetBool("Open", true);
            GetComponentInChildren<Door>().DoorOpen();
        }
    }


}
