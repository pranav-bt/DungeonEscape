using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonFireball : MonoBehaviour
{
    // Start is called before the first frame update
    Transform PlayerPos;
    [SerializeField] int damage;
    

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPos = FindObjectOfType<Player>().GetComponent<Transform>();
        Vector2 playerposition = new Vector2(PlayerPos.position.x, PlayerPos.position.y);
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), playerposition, 2 * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Player")
        {
            FindObjectOfType<Player>().damagehealth(damage);
            Destroy(gameObject);
        }
        if(collision.tag=="ForeGround")
        {
            Destroy(gameObject);
        }
        if (collision.tag == "Fireball")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
