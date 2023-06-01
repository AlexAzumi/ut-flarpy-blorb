using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [Header("References")]
    public AudioSource hitSound;
    public AudioSource pointSound;

    public void PlayHitSound()
    {
        hitSound.Play();
    }

    public void PlayPointSound()
    {
        pointSound.Play();
    }
}
