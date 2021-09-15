using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    int Health;
    void Start()
    {
        int healthcheck = FindObjectOfType<LevelController>().checkhealth();
        Health = healthcheck;
        FindObjectOfType<HealthDisplay>().changetext(Health);
    }

    public void damagehealth(int damage)
    {
        Health -= damage;
        FindObjectOfType<HealthDisplay>().changetext(Health);
        FindObjectOfType<LevelController>().storehealth(Health);
        if(Health==0)
        {
            GetComponent<Animator>().SetBool("Death", true);
            GetComponent<Ninja>().death();                           //varies as per the player
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
    }

    public void hazarddeath()
    {
        Health = 0;
        FindObjectOfType<HealthDisplay>().changetext(Health);
        GetComponent<Animator>().SetBool("Death", true);
        GetComponent<Ninja>().death();
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
