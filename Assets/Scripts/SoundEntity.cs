using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class SoundEntity
{
    public AudioClip clip;
    public string identifier;
    public bool isLooped;
    [Range(0f, 1f)]
    public float volumeMultiplier;
    [HideInInspector]
    public AudioSource source;
}
