using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaClimb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<NinjaExclusive>())
        {
            collision.GetComponent<NinjaExclusive>().highjumpallowed();
        }
    }
}
