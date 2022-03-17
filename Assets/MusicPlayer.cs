using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] AudioClip gamemenuaudio;
    [SerializeField] AudioClip levelaudio;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void OnLevelWasLoaded()
    {
        if (SceneManager.GetActiveScene().buildIndex >= 5)
        {
            GetComponent<AudioSource>().clip = levelaudio;
            GetComponent<AudioSource>().Play();
        }
        else
        {
            if(GetComponent<AudioSource>().clip == levelaudio)
            {
                GetComponent<AudioSource>().clip = gamemenuaudio;
                GetComponent<AudioSource>().Play();
            }
            else { }
        }
    }
    public float getvolume()
    {
        float val = GetComponent<AudioSource>().volume;
        return val;
    }
    public void setvolume(float value)
    {
        GetComponent<AudioSource>().volume = value;
    }
}
