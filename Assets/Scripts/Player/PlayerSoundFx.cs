using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundFx : MonoBehaviour
{

    public List<AudioClip> audioClip;
    private AudioSource audioSource;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }


    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(audioClip[1]);
    }
    public void PlayWalkSound()
    {
        //audioSource.Play(1);

    }

    public void PlayAttackSound()
    {
        audioSource.PlayOneShot(audioClip[2]);
    }
}
