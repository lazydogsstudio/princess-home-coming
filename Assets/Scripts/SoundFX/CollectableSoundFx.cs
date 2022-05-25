using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSoundFx : MonoBehaviour
{

    public List<AudioClip> audioClip;
    private AudioSource audioSource;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayCoinSound()
    {
        audioSource.PlayOneShot(audioClip[0]);
    }

    public void PlayGemSound()
    {
        audioSource.PlayOneShot(audioClip[0]);
    }
}
