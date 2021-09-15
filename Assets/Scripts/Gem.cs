using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    bool Once=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player" && Once==false)
        {
            Destroy(gameObject);
            FindObjectOfType<LevelController>().GemCollected();
            Once = true;
        }
    }
}
