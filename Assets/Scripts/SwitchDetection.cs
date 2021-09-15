using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        {
           GetComponentInParent<SwitchDoor>().playerdetected(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GetComponentInParent<SwitchDoor>().playeroutofrange(false);
        }
    }

    
}
