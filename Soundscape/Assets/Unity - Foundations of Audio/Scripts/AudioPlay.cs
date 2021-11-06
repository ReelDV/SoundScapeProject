using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour
{
    public AudioSource Enter;
    public AudioClip Exit;


    private void OnTriggerEnter(Collider other)
    {
        Enter.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        Enter.clip = Exit;
        Enter.Play();
    }
}
