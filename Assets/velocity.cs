using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class velocity : MonoBehaviour
{
    
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 5f, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag =="pickup")
        rb.velocity = new Vector3(0, 5f, 5f);
    }
}
