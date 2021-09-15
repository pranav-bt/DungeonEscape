using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mace : MonoBehaviour
{
    [SerializeField] Sprite RedMace;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<Player>().hazarddeath();
        }
    }
    public void spritechange()
    {
        GetComponent<SpriteRenderer>().sprite = RedMace;
    }
}
