using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingTime : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float time = 6f;
    void Start()
    {
        StartCoroutine("MainScreenTimer");
    }

    IEnumerator MainScreenTimer()
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Main Screen");
    }
}
