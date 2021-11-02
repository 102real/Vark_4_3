using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scense_04_Manager : MonoBehaviour
{
    public GameObject logo;
    public GameObject video;


    int ctend = 0;


    void Start()
    {

        StartCoroutine("Gost");


    }

    // Update is called once per frame
    void Update()
    {
        if (ctend > 1)
        {
            StopCoroutine("Gost");
        }
    }

    IEnumerator Gost()
    {
        Debug.Log("첫코루틴종료");
        yield return new WaitForSeconds(49f);
        logo.SetActive(true);
        video.SetActive(false);
        ctend = 2;


    }


}
