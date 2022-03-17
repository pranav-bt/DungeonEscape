using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectionDragon : MonoBehaviour
{
    Animator myanimator;
    bool playerinrange;
    Transform mouth;
    bool wait = false;
    float flipaxis;
    [SerializeField] GameObject fire;
    private void Start()
    {
        mouth = this.transform.Find("Mouth");
    }
    private void Update()
    {
        flipaxis = FindObjectOfType<Dragon>().GetComponent<Transform>().localScale.x;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            playeralert();
        }
    }
    public void playeralert()
    {
        GetComponentInChildren<Dragon>().playerinzone(GetComponent<Animator>());          //change to whatever the child enemy is
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInChildren<Dragon>().playeroutofzone(GetComponent<Animator>());     //change to whatever the child enemy is
    }
    public void destroycollider()
    {
        Destroy(gameObject);
    }
    public void fireballanimationinstantiate()
    {
        if(!wait)
        {
            wait = true;
            GetComponentInChildren<Dragon>().setwait(true);
            StartCoroutine("Fire");
        }
    }

    IEnumerator Fire()
    {
        if(flipaxis==1)
        {
            Instantiate(fire, mouth);
        }
        if(flipaxis==-1)
        {
            Instantiate(fire, mouth.position, Quaternion.Euler(0, 180, 0));
        }
        yield return new WaitForSeconds(3);
        wait = false;
        GetComponentInChildren<Dragon>().setwait(false);
    }

    public bool returnfire()
    {
        return wait;
    }
}
