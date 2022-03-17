using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    
    const string MASTER_VOLUME_KEY = "master volume";
    const string FIRSTTIME_KEY = "first time";
    const string LEVEL_KEY = "levelunlock";
    const float minvalue = 0f;
    const float maxvalue = 1f;
    public static void SetMasterVolume(int volume)
    {
        PlayerPrefs.SetInt(MASTER_VOLUME_KEY, volume);
    }
    public static int GetMasterVolume()
    {
        return PlayerPrefs.GetInt(MASTER_VOLUME_KEY);
    }
    public static int Getlevel()
    {
        return PlayerPrefs.GetInt(LEVEL_KEY);
    }
    public static void Setlevel(int unlock)
    {
        PlayerPrefs.SetInt(LEVEL_KEY, unlock);
    }
    public static int GetFirst()
    {
        return PlayerPrefs.GetInt(FIRSTTIME_KEY);
    }
    public static void SetFirst(int done)
    {
        PlayerPrefs.SetInt(FIRSTTIME_KEY, done);
    }

}
