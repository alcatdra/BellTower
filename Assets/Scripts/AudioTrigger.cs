using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.name == "audio trigger")
        //{
        audioSource.PlayOneShot(audioSource.clip, volumeBasedOnMagnitude(collision));
        Debug.Log(collision.relativeVelocity.magnitude);
        //}
    } 

    float volumeBasedOnMagnitude(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 3)
        return 1f;
        else return collision.relativeVelocity.magnitude / 3f;
    }
}
