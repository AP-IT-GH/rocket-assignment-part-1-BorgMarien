using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private Rigidbody Enemy;
    public float speed=0.001f;

    private bool up= true;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = this.gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPositionVector= Enemy.position;
        if(up){
            Enemy.position += new Vector3(0,speed *Time.deltaTime,0);
           if(currentPositionVector.y > 15.95606){
                this.up=false;
           }
        }
        else {
            Enemy.position += new Vector3(0,-speed *Time.deltaTime,0);
             if(currentPositionVector.y < 3){
                this.up=true;
           }
        }

     

    }
}
