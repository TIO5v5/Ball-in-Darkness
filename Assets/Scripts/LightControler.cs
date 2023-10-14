using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControler : MonoBehaviour
{

    Transform player;
    public Transform ground;

    Light myLight;
    public Color goodColor;
    public Color badColor;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Player>().transform;
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(player.position.x, player.position.y + 5f, player.position.z);

        ChangeLightColor();
    }

    private void ChangeLightColor()
    {
        float distanceToBoundary = GetMinDistanceToBound();
        float t = Mathf.InverseLerp(0, ground.localScale.x / 2, distanceToBoundary);
        Debug.Log(t);
        myLight.color = Color.Lerp(badColor, goodColor, t);
    }

    float GetMinDistanceToBound() => Mathf.Min(GetAllDistancesToBound());
    float[] GetAllDistancesToBound()
    {
        float zbound = ground.position.z + ground.localScale.z / 2;
        float xbound = ground.position.x + ground.localScale.x / 2;
        float[] bounds =
        {
            player.position.x + xbound,
            xbound - player.position.x,
            player.position.z + zbound,
            zbound - player.position.z
        };
        return bounds;
    }
}
