using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scense_02_Manager : MonoBehaviour
{
    // 오디오소스(재생파일)
    public AudioSource Play2_1;
    public AudioSource Play2_2;
    public AudioSource Play2_3;
    public AudioSource Play2_4;
    public AudioSource Play2_5;
    public AudioSource Play2_6;
    public AudioSource Play2_7;
    public AudioSource Play2_8;
    public AudioSource Play2_9;
    public AudioSource Play2_10;
    public AudioSource Play2_11;

    // 그랩 트리거 오브젝트
    public GameObject point01;
    public GameObject point02;
    public GameObject point03;
    public GameObject point04;
    public GameObject point05;
    public GameObject point06;
    public GameObject point07;
    public GameObject point08;

    // 콜라이더 놓을 포지션
    public GameObject collider02_1;
    public GameObject collider02_2;
    public GameObject collider02_3;
    public GameObject collider02_4;
    public GameObject collider02_5;
    public GameObject collider02_6;
    public GameObject collider02_7;
    public GameObject collider02_8;

    //각 콜라이더 트리거 에이블값
    bool colt01;
    bool colt02;
    bool colt03;
    bool colt04;
    bool colt05;
    bool colt06;
    bool colt07;
    bool colt08;
    bool colt09;

    private int coroutioneCount01 = 0;

    private bool coroutioneEnd01 = false;
    private bool coroutioneStart02 = false;
    private int coroutioneCount02 = 0;

    private bool coroutioneEnd02 = false;
    private bool coroutioneStart03 = false;
    private int coroutioneCount03 = 0;

    private bool coroutioneEnd03 = false;
    private bool coroutioneStart04 = false;
    private int coroutioneCount04 = 0;

    private bool coroutioneEnd04 = false;
    private bool coroutioneStart05 = false;
    private int coroutioneCount05 = 0;

    private bool coroutioneEnd05 = false;
    private bool coroutioneStart06 = false;
    private int coroutioneCount06 = 0;

    private bool coroutioneEnd06 = false;
    private bool coroutioneStart07 = false;
    private int coroutioneCount07 = 0;

    private bool coroutioneEnd07 = false;
    private bool coroutioneStart08 = false;
    private int coroutioneCount08 = 0;

    private bool coroutioneEnd08 = false;
    private bool coroutioneStart09 = false;
    private int coroutioneCount09 = 0;

    private bool coroutioneEnd09 = false;
    private bool coroutioneStart10 = false;
    private int coroutioneCount10 = 0;

    private bool coroutioneEnd10 = false;
    private bool coroutioneStart11 = false;
    private int coroutioneCount11 = 0;



    private void Start()
    {
        StartCoroutine("SoundC1");

        


    }

    void Update()
    {
        // 트리거 에이블값 최신화
        colt01 = collider02_1.GetComponent<Collider02_1>().collider021;
        colt02 = collider02_2.GetComponent<Collider02_2>().collider022;
        colt03 = collider02_3.GetComponent<Collider02_3>().collider023;
        colt04 = collider02_4.GetComponent<Collider02_4>().collider024;
        colt05 = collider02_5.GetComponent<Collider02_5>().collider025;
        colt06 = collider02_6.GetComponent<Collider02_6>().collider026;
        colt07 = collider02_7.GetComponent<Collider02_7>().collider027;

        //사운드1 코루틴 중지(콜라이터, 트리거 생성)
        if (coroutioneEnd01 && coroutioneCount01<1)
        {
            StopCoroutine("SoundC1");
            coroutioneStart02 = true;
            coroutioneCount01++;
            collider02_1.SetActive(true);
            point01.SetActive(true);
        }

        //사운드2 코루틴 스타트
        if (coroutioneStart02  && colt01 && coroutioneCount02<1)
        {
            StartCoroutine("SoundC2");
            coroutioneCount02++;
        }

        //사운드2 코루틴 중지(콜라이터, 트리거 생성)
        if (coroutioneEnd02 && coroutioneCount02<1)
        {
            StopCoroutine("SoundC1");
            coroutioneCount02++;
        }

        
    }

    


    IEnumerator SoundC1()
    { 
        yield return new WaitForSeconds(4f);
        Debug.Log("SoundC1 시작");
        Play2_1.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC1 끝남");
        coroutioneEnd01 = true;
    }

    IEnumerator SoundC2()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC2 시작");
        Play2_2.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC2 끝남");
        coroutioneEnd02 = true;
    }

    IEnumerator SoundC3()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC3 시작");
        Play2_3.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC3 끝남");
        coroutioneEnd03 = true;
    }

    IEnumerator SoundC4()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC4 시작");
        Play2_4.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC4 끝남");
        coroutioneEnd05 = true;
    }
    IEnumerator SoundC5()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC5 시작");
        Play2_5.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC5 끝남");
        coroutioneEnd05 = true;
    }

    IEnumerator SoundC6()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC6 시작");
        Play2_6.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC6 끝남");
        coroutioneEnd06 = true;
    }

    IEnumerator SoundC7()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC7 시작");
        Play2_7.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC7 끝남");
    }

    IEnumerator SoundC8()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC8 시작");
        Play2_8.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC8 끝남");
    }

    IEnumerator SoundC9()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC9 시작");
        Play2_3.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC9 끝남");
    }

    IEnumerator SoundC10()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC10 시작");
        Play2_10.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC10 끝남");
    }

    IEnumerator SoundC11()
    {
        yield return new WaitForSeconds(2f);
        Debug.Log("SoundC11 시작");
        Play2_11.Play();
        yield return new WaitForSeconds(15f);
        Debug.Log("SoundC11 끝남");
    }

   
}
