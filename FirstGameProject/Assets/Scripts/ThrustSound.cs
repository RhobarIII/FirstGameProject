using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustSound : MonoBehaviour
{
    AudioSource thrust;
    void Start()
    {
        thrust = gameObject.GetComponent<AudioSource>();
    }

    void sound()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            thrust.Play();
            Debug.Log("PowinnoGraæ");
        }
        thrust.Stop();
    }
    void Update()
    {
        sound();
    }
}
