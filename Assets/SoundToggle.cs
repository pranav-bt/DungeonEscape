using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Toggle tg;
    void Awake()
    {
        if(PlayerPrefsController.GetMasterVolume() == 0)
        {
            tg.isOn = false;
        }
        if (PlayerPrefsController.GetMasterVolume() == 1)
        {
            tg.isOn = true;

        }
    }
    public void checkmusic()
    {
        if(tg.isOn == true)
        {
            FindObjectOfType<MusicPlayer>().setvolume(0);
        }
        if(tg.isOn == false)
        {
            FindObjectOfType<MusicPlayer>().setvolume(1);
        }
    }
   
}
