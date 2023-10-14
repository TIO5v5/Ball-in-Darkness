using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testt : MonoBehaviour
{
    public GameObject[] objectArray;
    public Light[] pointLight;
    public Rigidbody[] rigidbodies;
    public List<GameObject> objectList = new List<GameObject>();
    void Start()
    {
        rigidbodies = FindObjectsOfType<Rigidbody>();
        //objectArray[0].name = "Tokito";
        //objectArray[0].GetComponent< Renderer > ().material.color = Color.black;
        //objectArray[1].GetComponent<Renderer>().material.color = Color.blue;
        for (int i = 0; i < objectArray.Length; i++)
        {
            objectArray[i].GetComponent<Renderer>().material.color = Color.red;
            objectArray[i].AddComponent<Rigidbody>();
        }
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            for (int i = 0; i < objectArray.Length; i++)
            {
                objectArray[i].GetComponent<Rigidbody>().AddForce(0f, 10f, 0f);
            }
            for (int i = 0; i < pointLight.Length; i++)
            {
                pointLight[i].color = Color.red;
            }
        }
        else
        {
            for (int i = 0; i < pointLight.Length; i++)
            {
                pointLight[i].color = Color.white;
            }
        }
    }
}
