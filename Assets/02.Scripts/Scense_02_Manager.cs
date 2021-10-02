using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scense_02_Manager : MonoBehaviour
{
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
    public AudioSource Play2_12;


    public GameObject col021;

    Collider02_1 collider02_1;

    private bool coroutioneEnd01 = false;
    private bool coroutioneStart01 = false;
    private int coroutioneCount01 = 0;

    


    private void Start()
    {
        StartCoroutine("SoundC1");

        collider02_1 = GameObject.Find("Collider02_1").GetComponent<Collider02_1>();
    }

    void Update()
    {
        if (coroutioneEnd01)
        {
            StopCoroutine("SoundC1");
            coroutioneStart01 = true;
            
        }

        if (coroutioneStart01 && coroutioneCount01<1)
        {
            StartCoroutine("SoundC2");
            coroutioneCount01++;
        }

        

        if (collider02_1.collider021 == true)
        {

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
        
    }
  
}
