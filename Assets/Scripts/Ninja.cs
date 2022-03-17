using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Ninja : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float playerspeed = 2f;
    Rigidbody2D myrigidbody;
    Animator myanimator;
    PolygonCollider2D myfeetcollider;
    [SerializeField] float jumpvelocity;
    float normaljumpvelocity;
    bool isalive=true;
    bool levelcomplete = false;
    void Start()
    {
        normaljumpvelocity = jumpvelocity;
        myrigidbody = GetComponent<Rigidbody2D>();
        myanimator = GetComponent<Animator>();
        myfeetcollider = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        if (!isalive || levelcomplete)
        {
            return;
        }
        run();
        Jump();
      
    }

    public void setlevelcomplete()
    {
        levelcomplete = true;
        myrigidbody.velocity = new Vector2(0, 0);
    }

    public void death()
    {
        isalive = false;
        StartCoroutine("menuondeath");
    }

    IEnumerator menuondeath()
    {
        yield return new WaitForSeconds(4);
        FindObjectOfType<SceneLoader>().pausegame();
    }
    private void Jump()
    {
        bool grnd = myfeetcollider.IsTouchingLayers(LayerMask.GetMask("Ground"));
        myanimator.SetBool("Ground", grnd);
        if (!grnd)
        {
            return;
        }
        if(CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            
            
            Vector2 jump = new Vector2(myrigidbody.velocity.x, jumpvelocity);
            myrigidbody.velocity = (jump);
            
        }
    }
    public void highjump(float value)
    {
        jumpvelocity = value;
    }
    public void normaljump()
    {
        jumpvelocity = normaljumpvelocity;
    }

    private void run()
    {
        float horval = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector2 val = new Vector2(horval * playerspeed, myrigidbody.velocity.y);
        myrigidbody.velocity = val;
        spriteflip(horval);
        bool playermotion = Mathf.Abs(horval) > 0;
        myanimator.SetBool("Running", playermotion);
    }

    private void spriteflip(float horval)
    {
        Transform sp = GetComponentInChildren<Transform>();
        if (horval>0)
        {
            sp.localScale = new Vector2(1, 1);
        }
        if(horval<0)
        {
            sp.localScale = new Vector2(-1, 1);
        }
    }

    public bool isplayeralive()
    {
        return isalive;
    }

    public void setdeathanimoff()
    {
        GetComponentInParent<Animator>().SetBool("Death", false);
    }
    public void setlevelcompleteanimoff()
    {
        myanimator.SetBool("LevelDone", false);
    }
    public void backtolevelscreen()
    {
        if (SceneManager.GetActiveScene().buildIndex < 15)
        { FindObjectOfType<SceneLoader>().levelscreen(); }
        if (SceneManager.GetActiveScene().buildIndex >= 15)
        { FindObjectOfType<SceneLoader>().levelscreen1(); }
    }
}
