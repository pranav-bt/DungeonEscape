using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    Animator myanimator;
    bool playerinrange;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playeralert();
        }
    }
    public void playeralert()
    {
        GetComponentInChildren<Gin>().playerinzone(GetComponent<Animator>());          //change to whatever the child enemy is
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInChildren<Gin>().playeroutofzone(GetComponent<Animator>());     //change to whatever the child enemy is
    }
    public void attack(int damage)
    {
        FindObjectOfType<Player>().damagehealth(damage);
    }
    public void destroycollider()
    {
        Destroy(gameObject);
    }
}

