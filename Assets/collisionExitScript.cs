using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionExitScript : MonoBehaviour
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

    private void OnCollisionExit(Collision collision)
    {
        rb.AddForce(new Vector3(0, 5f, 0), ForceMode.Impulse);
    }
   
}
