using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectionDemon : MonoBehaviour
{
    Animator myanimator;
    bool playerinrange;
    bool candamage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playeralert();
        }
    }
    public void playeralert()
    {
        GetComponentInChildren<Demon>().playerinzone(GetComponent<Animator>());          //change to whatever the child enemy is
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInChildren<Demon>().playeroutofzone(GetComponent<Animator>());     //change to whatever the child enemy is
    }
    public void attack(int damage)
    {
        FindObjectOfType<Player>().damagehealth(damage);
    }
    public void destroycollider()
    {
        Destroy(gameObject);
    }
    public void candamagesetrue()
    {
        candamage = true;
    }
    public void candamagesetfalse()
    {
        candamage = false;
    }
    public bool candamagee()
    {
        return candamage;
    }
}
