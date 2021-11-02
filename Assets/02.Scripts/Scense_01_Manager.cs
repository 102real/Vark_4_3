using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scense_01_Manager : MonoBehaviour
{
    public GameObject PadeObj;

    public GameObject StartMap;
    public GameObject Scense01;
    public GameObject ChrDB;

    public GameObject Title;
    public GameObject Sound1;

    public GameObject Collider01_1;
    public GameObject Collider01_2;
    public GameObject Collider01_3;



    private Animator PadeCtr;

    bool start01 = false;
    bool start02 = false;

    int count01 = 0;
    int count02 = 0;

    public GameObject point10;
    public GameObject collider01_1;
    public GameObject collider01_2;
    bool colt10 = false;
    bool colt11 = false;

    int scense01end=0;
    int scense01end2=0;


    void Start()
    {

        PadeCtr = PadeObj.GetComponent<Animator>();

        StartMap.SetActive(true);
        Scense01.SetActive(false);
        
        StartCoroutine("GoGo1");

        
    }

    // Update is called once per frame
    void Update()
    {
        colt10 = collider01_1.GetComponent<Collider01_01>().collider010;
        colt11 = collider01_2.GetComponent<Collider01_01>().collider010;

        if (start01& count01 < 1)
        {
            count01++;
            StopCoroutine("GoGo1");
            Debug.Log("코루틴1 종료");
            StartCoroutine("GoGo2");

        }

        if (start02 & count02 <1)
        {
            count02++;
            StopCoroutine("GoGo2");
            Debug.Log("코루틴2 종료");

            
        }

        if (colt10 & scense01end < 1)
        {
            scense01end++;
            SceneManager.LoadScene("cave scene 2");
        }

        if(colt11 & scense01end2 < 1)
        {
            scense01end2++;
            SceneManager.LoadScene("cave scene 2");
        }
    }

    IEnumerator GoGo1()
    {
        Debug.Log("첫코루틴종료");
        yield return new WaitForSeconds(10f);
        Title.SetActive(false);
        Sound1.SetActive(true);
        yield return new WaitForSeconds(10f);

        PadeCtr.SetTrigger("FadeOut01");
        yield return new WaitForSeconds(1f);
        StartMap.SetActive(false);
        Scense01.SetActive(true);
        PadeCtr.SetTrigger("FadeIn01");

        start01 = true;
    }

    IEnumerator GoGo2()
    {
        
        ChrDB.SetActive(true);
        yield return new WaitForSeconds(57f);
        Collider01_1.SetActive(true);
        yield return new WaitForSeconds(1f);
        Collider01_2.SetActive(true);
        yield return new WaitForSeconds(1f);
        Collider01_3.SetActive(true);
        yield return new WaitForSeconds(1f);
        
        yield return new WaitForSeconds(3f);
        Collider01_3.SetActive(false);
        Collider01_2.SetActive(false);
        Collider01_1.SetActive(false);
        yield return new WaitForSeconds(19f);
        
        point10.SetActive(true);
        yield return new WaitForSeconds(8f);
        start02 = true;
    }



}
