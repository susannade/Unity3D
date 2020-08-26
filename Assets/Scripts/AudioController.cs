using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class AudioController : MonoBehaviour
{
    public SoundEntity[] sounds;
    public static float volume = 0.7f;
    public static AudioController instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach (SoundEntity e in sounds)
        {
            e.source = gameObject.AddComponent<AudioSource>();
            e.source.clip = e.clip;
            e.source.volume = volume * e.volumeMultiplier;
            e.source.loop = e.isLooped;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Beep("background");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (SoundEntity e in sounds)
        {
            e.source.volume = volume * e.volumeMultiplier;
        }
    }
    public void Beep(string id)
    {
        try
        {
            SoundEntity chosenOne = Array.Find(sounds, sounds => sounds.identifier == id);
            chosenOne.source.Play();
        }
        catch (Exception ex)
        {
            Debug.Log("error" + ex.Message);
        }
    }

}
