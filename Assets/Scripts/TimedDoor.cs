using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDoor : MonoBehaviour
{
    // Start is called before the first frame update
    Vector2 doorclosescale;
    BoxCollider2D doorclosecollider;
    void Start()
    {
        doorclosescale = transform.localScale;
        doorclosecollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DoorOpen()
    {
        transform.localScale = new Vector2(1, 1);
        Destroy(GetComponent<BoxCollider2D>());
    }
    public void DoorClose()
    {
        transform.localScale = doorclosescale;
        gameObject.AddComponent<BoxCollider2D>();
    }
}
