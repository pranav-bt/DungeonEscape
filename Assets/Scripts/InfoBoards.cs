using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoBoards : MonoBehaviour
{
    // Start is called before the first frame update
    [TextArea(14, 10)] [SerializeField] string text;
    [SerializeField] GameObject textcanvas;
    [SerializeField] Canvas textcanvass;
    private void Awake()
    {
        textcanvas.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        { 
        textcanvass.GetComponentInChildren<Text>().text = text;
        textcanvas.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag=="Player")
        { 
        textcanvas.SetActive(false);
        textcanvass.GetComponentInChildren<Text>().text = null;
        }
    }
}
