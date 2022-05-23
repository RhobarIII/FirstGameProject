using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody RocketRigidbody;
    [SerializeField] float Power = 1000f;
    [SerializeField] float RotationPower = 100f;
    void ProcessRotation()
    {
       
        if(Input.GetKey(KeyCode.A))
        {
            Rotation(-RotationPower);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            RocketRigidbody.freezeRotation = true;
            Rotation(RotationPower);
            RocketRigidbody.freezeRotation = false;
        }
    }
    void Rotation(float Thrust)
    {
        transform.Rotate(Vector3.left * Thrust * Time.deltaTime);
    }
    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            
            Debug.Log("tHRUSTING");
            Vector3 Direction = Vector3.up;
            
            
            RocketRigidbody.AddRelativeForce(Direction * Power*Time.deltaTime);
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
