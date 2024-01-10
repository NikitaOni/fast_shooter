using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{

    public AudioMixerGroup Mixer;
    private void Start()
    {
        
    }

    public void ChangeVolume(float volume)
    {
        Mixer.audioMixer.SetFloat("Music", Mathf.Lerp(-80,0,volume));
    } 
}
