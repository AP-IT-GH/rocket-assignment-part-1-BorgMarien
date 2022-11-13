using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsScript : MonoBehaviour
{

    public GameObject objPrefabCube;

    public GameObject objPrefabSphere;

     public GameObject objPrefabCapsule;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObjects());

    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            float randomTime = 0.05f;
            float randomPositionX = Random.Range(-10f, 10f);
            float randomPositionZ = Random.Range(-10f, 10f);

            float r = Random.Range(0, 3);

            yield return new WaitForSeconds(randomTime);

            GameObject spawn = null;
            if (r < 1)
            {
                spawn = objPrefabCube;
            }
            else if (r > 1 && r <= 2)
                spawn = objPrefabSphere;
            else
                spawn = objPrefabCapsule;

            Instantiate(spawn, new Vector3(randomPositionX, 20, randomPositionZ), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
