using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody RocketRigidbody;
    AudioSource thrust;

    [SerializeField] float Power = 1000f;
    [SerializeField] float RotationPower = 100f;
 
    void Thrusting()
    {
        Debug.Log("tHRUSTING");
        Vector3 Direction = Vector3.up;
        RocketRigidbody.AddRelativeForce(Direction * Power * Time.deltaTime);
    }

    void Rotation(float Thrust)
    {
        transform.Rotate(Vector3.left * Thrust * Time.deltaTime);
    }


    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Thrusting();
          
            if (!thrust.isPlaying)
            {
                thrust.Play();
            }
               
        }
        else
        {
            thrust.Stop();
        }
    }
    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
            Rotation(-RotationPower);

        else if (Input.GetKey(KeyCode.D))
        {
            RocketRigidbody.freezeRotation = true;
            Rotation(RotationPower);
            RocketRigidbody.freezeRotation = false;
        }
    }



    private void Start()
    {
        RocketRigidbody= GetComponent<Rigidbody>();
        thrust = GetComponent<AudioSource>();

    }
    void Update()
    {
        ProcessRotation();
        ProcessThrust();
    }
}
