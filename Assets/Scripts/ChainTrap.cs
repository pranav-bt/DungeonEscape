using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainTrap : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        { 
        Destroy(GetComponent<HingeJoint2D>());
        GetComponentInChildren<Mace>().spritechange();
        }
    }
}
