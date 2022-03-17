using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerCameraChange : MonoBehaviour
{
    // Start is called before the first frame update
    Cinemachine.CinemachineVirtualCamera cam;
    void Start()
    {
        cam = GetComponent<Cinemachine.CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    public void changefollow(GameObject player)
    {
        cam.Follow = player.GetComponent<Transform>();
    }
    void Update()
    {
        
    }
}
