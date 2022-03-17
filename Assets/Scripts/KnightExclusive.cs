using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class KnightExclusive : MonoBehaviour
{
    // Start is called before the first frame update
    Animator myanimator;
    bool swordcheck=false;
    void Start()
    {
        myanimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    public void Attack()
    {
        if (GetComponent<Ninja>().isplayeralive()==true)
        { 
        if (CrossPlatformInputManager.GetButtonDown("Fire2"))
        {
            myanimator.SetBool("Attack", true);
        }
        }
    }
    

    public void swordchecktrue()
    {
        swordcheck = true;
    }

    public void AttackOff()
    {
        myanimator.SetBool("Attack", false);
        swordcheck = false;
    }

    public bool swordregistercheck()
    {
        return swordcheck;
    }
}
