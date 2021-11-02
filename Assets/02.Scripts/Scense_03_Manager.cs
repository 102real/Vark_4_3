using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scense_03_Manager : MonoBehaviour
{
    bool start01 = true;
    //public GameObject Sound301;

    int ctend = 0;

    void Start()
    {
        StartCoroutine("SoundC3_1");

    }

    private void Update()
    {

        if (ctend > 1)
        {
            StopCoroutine("Gost");
            SceneManager.LoadScene("cave scene 4");
        }
        
    }

    IEnumerator SoundC3_1()
    {
        yield return new WaitForSeconds(40f);
        //Sound301.SetActive(true);
        Debug.Log("코루틴시작");
        ctend = 2;

    }


   
}
