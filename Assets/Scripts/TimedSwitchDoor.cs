using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TimedSwitchDoor : MonoBehaviour
{
    bool playerinrange = false;
    [SerializeField] float DoorTimer;
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
        if (playerinrange == true)
        {
            CheckDoorOpen();
        }
    }

    private void CheckDoorOpen()
    {
        if (CrossPlatformInputManager.GetButtonDown("Fire1"))
        {
            StartCoroutine("timeddooropen");
        }
    }

    IEnumerator timeddooropen()
    {
        GetComponent<Animator>().SetBool("Open", true);
        GetComponentInChildren<TimedDoor>().DoorOpen();
        yield return new WaitForSeconds(DoorTimer);
        GetComponentInChildren<TimedDoor>().DoorClose();
        GetComponent<Animator>().SetBool("Open", false);
    }

}
