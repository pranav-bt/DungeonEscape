using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordCollider : MonoBehaviour
{
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        bool swordregistercheck = FindObjectOfType<KnightExclusive>().swordregistercheck();
        if(swordregistercheck==true && collision.tag=="Enemy")
        {
            if (collision.GetComponent<Gin>())
            { collision.GetComponent<Gin>().destroyparent(); }
        }
    }
}
