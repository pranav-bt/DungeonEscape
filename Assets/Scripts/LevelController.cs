using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    // Start is called before the first frame update
    Gem[] Gemsinlevel;
    int NoofGemsinlevel;
    int health=100;
    void Start()
    {
        Gemsinlevel = FindObjectsOfType<Gem>();
        NoofGemsinlevel = Gemsinlevel.Length;
        FindObjectOfType<GemsDisplay>().changetextgems(NoofGemsinlevel);
    }

    public void GemCollected()
    {
        NoofGemsinlevel -= 1;
        FindObjectOfType<GemsDisplay>().changetextgems(NoofGemsinlevel);
    }

    public int ReturnGems()
    {
        return NoofGemsinlevel;
    }

    public void storehealth(int healthreceived)
    {
        health = healthreceived;
    }

    public int checkhealth()
    {
        return health;
    }
}
