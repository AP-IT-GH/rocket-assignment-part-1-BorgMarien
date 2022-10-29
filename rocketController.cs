using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class rocketController : MonoBehaviour
{
    private Rigidbody rb;



    void Thrust()
    {
        rb.AddRelativeForce(Vector3.up * 25);

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var force = 0.5f;
        if (Input.GetKey(KeyCode.Space))
        {
            Thrust();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
            transform.Rotate( force,0,0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            transform.Rotate(-force, 0,0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
               transform.Rotate( 0, 0,force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            transform.Rotate(0, 0,- force);
        }
    }
}