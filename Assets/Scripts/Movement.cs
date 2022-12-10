using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            Debug.Log("I'm flying now");
        }
    }
    private void Rotation()
    {
        if(Input.GetKey(KeyCode.A))
        {
            Debug.Log("Left");
        }
        else if(Input.GetKey(KeyCode.D))
        {
            Debug.Log("Right");
        }
    }
}
