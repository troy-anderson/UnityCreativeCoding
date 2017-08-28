using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketchSphere : MonoBehaviour
{

    public GameObject myPrefab;

    void Start()
    {

        //Create Variable to Store Cube Amounts
        int totalCubes = 20;

        float totaldistance = 2.9f;
        for (int i = 0; i < totalCubes; i++)
        {
            float perc = i / (float)totalCubes;
            float sin = Mathf.Sin(perc * Mathf.PI / 2);
            float x = 1.8f + sin * totaldistance;
            float y = 5.0f;
            float z = 0.0f;

            {
                var newSphere = (GameObject)Instantiate(myPrefab, new Vector3(Random.Range(-4.0f, 4.0f), 8.0f, Random.Range(-4.0f, 4.0f)), Quaternion.identity);
                newSphere.GetComponent<Renderer>().material.color = Color.white;
                newSphere.GetComponent<cubeScript>().SetSize(.5f * (1.0f - perc));
                newSphere.GetComponent<cubeScript>().rotateSpeed = .45f + perc * 4.0f;
            }
        }
    }

    void Update()
    {



    }
}
