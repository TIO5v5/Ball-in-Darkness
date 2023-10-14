using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSkin : MonoBehaviour
{
    public GameObject selectedSkin;
    private Material skinMaterial;
    void Start()
    {
        skinMaterial = selectedSkin.GetComponent<MeshRenderer>().sharedMaterial;
        GetComponent<MeshRenderer>().material = skinMaterial;
    }

}
