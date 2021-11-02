using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public GameObject music;

    public void MusicStart()
    {
        music.SetActive(true);
        Debug.Log("À½¾ÇÀç»ý");
    }
}
