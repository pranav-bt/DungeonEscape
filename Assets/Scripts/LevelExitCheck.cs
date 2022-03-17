using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class LevelExitCheck : MonoBehaviour
{
    [SerializeField] int levelnumber;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(FindObjectOfType<LevelController>().ReturnGems()==0)     //check all required conditions here
        {
            if ((CrossPlatformInputManager.GetButtonDown("Fire1")))
            { 
                FindObjectOfType<Ninja>().GetComponent<Animator>().SetBool("LevelDone", true);
                FindObjectOfType<Ninja>().setlevelcomplete();
                int unlocklevel = PlayerPrefsController.Getlevel();
                if(levelnumber == unlocklevel)
                {
                    PlayerPrefsController.Setlevel(unlocklevel + 1);
                    if(levelnumber==0)
                    {
                        PlayerPrefsController.SetFirst(1);
                    }
                }
               
            }
        }
    }
}
