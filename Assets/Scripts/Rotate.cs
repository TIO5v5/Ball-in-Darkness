using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Vector3 rotateVelocity = new Vector3(0f,90f,0f);

    void Update()
    {
        transform.Rotate(rotateVelocity * Time.deltaTime);
    }
}
