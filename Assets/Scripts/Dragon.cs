using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    bool playerfound = false;
    Player player;
    Rigidbody2D myrigidbody;
    PolygonCollider2D myvision;
    bool isalive;
    bool move = true;
    bool wait;
    private void Update()
    {

        isalive = FindObjectOfType<Ninja>().isplayeralive();
        if (!isalive)
        { return; }
        if (playerfound == true)
        {
            locateplayer();
        }
    }
    public void setwait(bool value)
    {
        wait = value;
    }

    private void OnTriggerStay2D(Collider2D other)
    {

        Debug.Log("Dragon " + GetComponentInParent<EnemyDetectionDragon>().returnfire());
        if (other.tag == "Player" && isalive && !GetComponentInParent<EnemyDetectionDragon>().returnfire())
        {
            GetComponentInParent<Animator>().SetBool("Attack", true);
            move = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponentInParent<Animator>().SetBool("Attack", false);
        move = true;
    }

    private void locateplayer()
    {
        Vector2 pos = new Vector2(player.transform.position.x, player.transform.position.y);
        movetowardsplayer(pos);
    }

    private void movetowardsplayer(Vector2 location)
    {
        if (transform.position.x - location.x < Mathf.Epsilon)
        { transform.localScale = new Vector2(1, 1); }
        if (transform.position.x - location.x > Mathf.Epsilon)
        { transform.localScale = new Vector2(-1, 1); }
        if (move)
        {
            Vector2 finallocation = new Vector2(location.x, transform.position.y);
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), finallocation, 1 * Time.deltaTime);
        }
    }

    public void playerinzone(Animator myanimator)
    {
        myanimator.SetBool("Walk", true);
        findplayer();
    }

    private void findplayer()
    {
        player = FindObjectOfType<Player>();
        playerfound = true;
    }

    public void playeroutofzone(Animator myanimator)
    {
        myanimator.SetBool("Walk", false);
        playerfound = false;
    }

    public void destroyparent()
    {
        GetComponentInParent<EnemyDetectionDragon>().destroycollider();
    }
    private void OnDestroy()
    {
        GetComponentInParent<EnemyDetectionDragon>().destroycollider();
    }
}
