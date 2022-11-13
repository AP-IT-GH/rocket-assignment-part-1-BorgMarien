using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddPoint : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "Player"){
            Debug.Log("hit");
            Text points = GameObject.Find("main canvas/PointUI").GetComponent<Text>();
            Debug.Log(points);
            int Number_of_points = int.Parse(points.text) + 1;
            Debug.Log(Number_of_points);
            points.text= Number_of_points.ToString();
        }
    }
}
