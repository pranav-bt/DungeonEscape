using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orangegem : MonoBehaviour
{
    [SerializeField] GameObject knight;
    [SerializeField] GameObject ninja;
    bool once=false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<NinjaExclusive>() && once==false)
        {
            once = true;
            GameObject newhero = Instantiate(knight, other.transform.position, Quaternion.identity) as GameObject;
            FindObjectOfType<PLayerCameraChange>().changefollow(newhero);
            Destroy(other.gameObject);
            StartCoroutine("Setfalse");
        }
        if (other.GetComponent<KnightExclusive>() && once == false)
        {
            once = true;
            GameObject newhero = Instantiate(ninja, other.transform.position, Quaternion.identity) as GameObject;
            FindObjectOfType<PLayerCameraChange>().changefollow(newhero);
            Destroy(other.gameObject);
            StartCoroutine("Setfalse");
        }
    }
    IEnumerator Setfalse()
    {
        yield return new WaitForSeconds(5);
        once = false;
    }
}
