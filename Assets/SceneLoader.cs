using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] GameObject MainCanvas;
    [SerializeField] GameObject PauseMenuCanvas;
    float ogvolume;
    float time, deltatime;
    [SerializeField] public UnityEngine.UI.Toggle toggle;
    private void Start()
    {
        time = Time.timeScale;
    }
    public void levelscreen()
    {
        SceneManager.LoadScene("Selector Level");
    }
    public void levelscreen1()
    {
        SceneManager.LoadScene("Selector Level 1");
    }
    public void levelloader(float value,int level)
    {
        if(value==255)
        {
            SceneManager.LoadScene("Level" + level);
        }
    }
    public void optionsscreen()
    {
        SceneManager.LoadScene("Options Screen");
    }
    public void maintolevelscreen()
    {
        int first = PlayerPrefsController.GetFirst();
        if(first==0)
        {
            SceneManager.LoadScene("IntroLevel");
        }
        if(first==1)
        {
            levelscreen();
        }
    }
    public void mainscreen()
    {
        SceneManager.LoadScene("Main Screen");
    }
    public void pausegame()
    {
        Time.timeScale = 0f;
        MainCanvas.SetActive(false);
        PauseMenuCanvas.SetActive(true);
    }
    public void playgame()
    {
        Time.timeScale = 1f;
        MainCanvas.SetActive(true);
        PauseMenuCanvas.SetActive(false);
    }
    public void restartlevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void gamemenutolevelscreen()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Selector Level");
    }
    public void gamequit()
    {
        Application.Quit();
    }
    public void areyousurecanvas()
    {
        MainCanvas.SetActive(false);
        PauseMenuCanvas.SetActive(true);
    }
    public void areyousurecanvasrevert()
    {
        MainCanvas.SetActive(true);
        PauseMenuCanvas.SetActive(false);
    }
    public void gamereset()
    {
        PlayerPrefsController.Setlevel(0);
        PlayerPrefsController.SetFirst(0);
        MainCanvas.SetActive(true);
        PauseMenuCanvas.SetActive(false);
    }
    public void soundcontrol()
    {
        Debug.Log("Its Happening on its own");
        float val = FindObjectOfType<MusicPlayer>().getvolume();
        Debug.Log(val);
        if (val != 0 )
        {
            FindObjectOfType<MusicPlayer>().setvolume(0);
            PlayerPrefsController.SetMasterVolume(1);
            FindObjectOfType<SoundToggle>().checkmusic();
        }
        if(val == 0)
        {
            FindObjectOfType<MusicPlayer>().setvolume(1);
            PlayerPrefsController.SetMasterVolume(0);
            FindObjectOfType<SoundToggle>().checkmusic();
        }
    }
}
