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

    

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine("SoundC1");
        }

        
    }

    


    IEnumerator SoundC1()
    {
        Debug.Log("시작");
        Play2_1.Play();
        yield return new WaitForSeconds(4f);
        Debug.Log("4초 지남");
    }
}
