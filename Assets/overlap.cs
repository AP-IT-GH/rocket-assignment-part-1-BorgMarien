using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class overlap : MonoBehaviour
{
    Collider[] warningSphere;
    LayerMask mask ;
    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("enemy");
    }

    // Update is called once per frame
    void Update()
    {
       
        warningSphere = Physics.OverlapSphere(transform.position, 4,mask);
       bool InWarningSpace = Physics.CheckSphere(this.transform.position, 2,mask);
        Debug.Log(InWarningSpace);
        Debug.Log(this.transform.position);
    }
}
