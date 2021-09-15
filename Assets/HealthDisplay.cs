using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public void changetext(int value)
    {
        if(value>=0)
        { GetComponent<TextMeshProUGUI>().text = ("Health - " + value.ToString()); }    
    }
    
}
