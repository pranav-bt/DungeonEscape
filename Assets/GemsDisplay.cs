using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GemsDisplay : MonoBehaviour
{
    public void changetextgems(int value)
    {

        GetComponent<TextMeshProUGUI>().text = ("Gems - " + value.ToString());
    }
}
