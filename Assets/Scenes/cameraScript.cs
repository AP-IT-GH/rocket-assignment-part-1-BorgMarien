using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cameraScript : MonoBehaviour
{
    float rotateY = 0f;
    Ray ray;
    Camera cam;
    RaycastHit hit;
    int layermask = 0;
    public TMP_Text textArea;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        layermask = Physics.AllLayers;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rotateY+=0.5f;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rotateY-=0.5f;

        }
        cam.transform.eulerAngles = new Vector3(0, rotateY, 0);
        ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
               
         if (Physics.Raycast(ray,out hit, 120))
        {
            Debug.Log(ray.origin);

            if(hit.collider.tag == "pickup")
            {
               Debug.Log("hit by ray");
                textArea.text = "hit by ray";
            }
        }
    }
}
