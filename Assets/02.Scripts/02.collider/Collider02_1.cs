using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider02_1 : MonoBehaviour
{

    public bool collider021 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"Trigger !");
        collider021 = true;
    }

}
