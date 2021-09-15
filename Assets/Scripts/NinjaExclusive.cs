using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class NinjaExclusive : MonoBehaviour
{
    // Start is called before the first frame update
    Animator myanimator;
    [SerializeField] GameObject Fireball;
    [SerializeField] PhysicsMaterial2D ZeroFriction;
    [SerializeField] float highjumplimit;
    Vector2 size;
    void Start()
    {
        myanimator = GetComponent<Animator>();
        size = GetComponent<CapsuleCollider2D>().size;
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if(GetComponent<Ninja>().isplayeralive()==true)
        { 
        if (CrossPlatformInputManager.GetButtonDown("Fire2"))
        {
            myanimator.SetBool("Attack", true);

        }
        }
    }

    public void AttackOff()
    {
        myanimator.SetBool("Attack", false);
    }

    public void fireball()
    {
        Transform sp = GetComponentInChildren<Transform>();
        if (sp.localScale.x == 1)
        {
            GameObject Fireballl = Instantiate(Fireball, transform.position, Quaternion.identity) as GameObject;
            Fireballl.GetComponent<Rigidbody2D>().velocity = new Vector2(5f, 0);
        }
        if (sp.localScale.x == -1)
        {
            GameObject Fireballl = Instantiate(Fireball, transform.position, Quaternion.Euler(0f, 0f, 180f)) as GameObject;
            Fireballl.GetComponent<Rigidbody2D>().velocity = new Vector2(-5f, 0);
        }

    }

    public void highjumpallowed()
    {
        StartCoroutine("HighJump");
    }

    IEnumerator HighJump()
    {
        GetComponent<Ninja>().highjump(highjumplimit);
        yield return new WaitForSeconds(5);
        GetComponent<Ninja>().normaljump();
    }
}
