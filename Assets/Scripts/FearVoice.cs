using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FearVoice : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip FearVoiceSound;
    SpawnCoin coinManager;
    Player player;

    float timeFromLastVoice;
    public float timeBetweenVoice = 60f;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        coinManager = FindObjectOfType<SpawnCoin>();
        player = FindObjectOfType<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        timeFromLastVoice += Time.deltaTime;

        if(timeFromLastVoice < timeBetweenVoice)
        {
            return;
        }

        Coin clossestCoin = coinManager.GetClosest(player.transform.position);
        float distanceToCoin = Vector3.Distance(clossestCoin.transform.position, player.transform.position);
        if(distanceToCoin < 10)
        {
            PlayFearVoiceSound();
            timeFromLastVoice = 0;
        }
    }

    private void PlayFearVoiceSound()
    {
        audioSource.clip = FearVoiceSound;
        audioSource.Play();
    }
}
