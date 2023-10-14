using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool isLose = false;
    LightControler[] allLightes;
    public static GameManager instance = null;
    AudioControler audioControler;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;

        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        allLightes = FindObjectsOfType<LightControler>();
        audioControler = FindObjectOfType<AudioControler>();
    }

    void LightSwitch( bool isLIghtOn)
    {
        //for (int i = 0; i < allLightes.Length; i++)
        //{
        //    allLightes[i].GetComponent<Light>().enabled = isLIghtOn;
        //}
        foreach (LightControler light in allLightes)
        {
            light.GetComponent<Light>().enabled = isLIghtOn;
        }
    }

    public void Lose()
    {
        isLose = true;
        LightSwitch(false);
        audioControler.PlayLoseSound();
    }
    public void RestartGame()
    {
        isLose = false;
        LightSwitch(true);
    }


    void Update()
    {
        
    }
}
