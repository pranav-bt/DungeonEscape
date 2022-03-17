using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Enemy")
        {
            if (collision.GetComponent<Gin>())
            { collision.GetComponent<Gin>().destroyparent(); }
            Destroy(gameObject);
        }
        if(collision.tag=="ForeGround")
        {
            Destroy(gameObject);
        }
    }
}
