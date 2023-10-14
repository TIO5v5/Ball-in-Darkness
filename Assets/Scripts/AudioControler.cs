using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip loseSound, deadSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void PlayLoseSound()
    {
        audioSource.clip = loseSound;
        audioSource.Play();
    }
    public void PlayDeadSound()
    {
        audioSource.clip = deadSound;
        audioSource.Play();
    }

}
