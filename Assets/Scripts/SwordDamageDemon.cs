using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamageDemon : MonoBehaviour
{
    [SerializeField] int damage;
    bool once = false;
    private void OnTriggerStay2D(Collider2D collision)
    {
        bool candamage = GetComponentInParent<EnemyDetectionDemon>().candamagee();
        if(collision.tag=="Player" && candamage && !once)
        {
            once = true;
            StartCoroutine("damageplayer");
        }
    }
    IEnumerator damageplayer()
    {
        Debug.Log("DamageDone");
        FindObjectOfType<Player>().damagehealth(damage);
        yield return new WaitForSeconds(1);
        once = false;
    }
}
