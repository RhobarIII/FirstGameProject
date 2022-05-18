using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody RocketRigidbody;
    void ProcessRotation()
    {
       
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Rotate Left");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Rotate right");
        }
    }
    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("tHRUSTING");
            RocketRigidbody.AddRelativeForce(Vector3.up);
        }
    }
    private void Start()
    {
        RocketRigidbody= GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        ProcessRotation();
        ProcessThrust();
    }
}
