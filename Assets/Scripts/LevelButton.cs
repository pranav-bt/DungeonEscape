using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int levelnumber;
    int levelcheck;
    void Start()
    {
        levelcheck = PlayerPrefsController.Getlevel();
        if(levelnumber  <= levelcheck)
        {
            Image img = GetComponent<Image>();
            var newcolor = img.color;
            newcolor.a = 255f;
            img.color = newcolor;
        }
    }
    public void levelstartcheck()
    {
        FindObjectOfType<SceneLoader>().levelloader(GetComponent<Image>().color.a, levelnumber);
    }
}
