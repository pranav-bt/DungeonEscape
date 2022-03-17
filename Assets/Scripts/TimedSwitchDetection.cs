using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSwitchDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GetComponentInParent<TimedSwitchDoor>().playerdetected(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GetComponentInParent<TimedSwitchDoor>().playeroutofrange(false);
        }
    }
}
