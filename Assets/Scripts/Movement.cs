using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thrustValue = 1000f;
    [SerializeField] float rotationValue = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Thrust();
        Rotation();
    }
    private void Thrust()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            // Debug.Log("I'm flying now");
            rb.AddRelativeForce(Vector3.up * thrustValue * Time.deltaTime);
        }
    }
    private void Rotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            // Debug.Log("Left");
            Rotate(rotationValue);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            // Debug.Log("Right");
            Rotate(-rotationValue);
        }
    }
    private void Rotate(float letRotateThisFrame)
    {
        transform.Rotate(Vector3.forward * letRotateThisFrame * Time.deltaTime);
    }
}
