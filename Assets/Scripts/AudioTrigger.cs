using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audioSource;
    void OnCollisionEnter(Collision collision){
        audioSource.PlayOneShot(audioSource.clip, volumeBasedOnMagnitude(collision));
        Debug.Log(collision.relativeVelocity.magnitude);
    } 

    float volumeBasedOnMagnitude(Collision collision)
    {
        /*old code   
        if (collision.relativeVelocity.magnitude > 2)
        return 1f;
        else if (collision.relativeVelocity.magnitude > 1 && collision.relativeVelocity.magnitude < 2)
        return 0.5f;
        else return 0.1f; */
        if (collision.relativeVelocity.magnitude > 3)
        return 1f;
        else return collision.relativeVelocity.magnitude / 3f;
    }
}
