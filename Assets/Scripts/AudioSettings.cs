using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioSettings : MonoBehaviour
{
    public string volumeParameter = "MasterVolume";
    public AudioMixer Mixer;
    public Slider slider;

    private float _volumeValue;
    private const float _multipyer = 20f;

    private void Awake()
    {
        slider.onValueChanged.AddListener(HandleSliderValueChanged);
    }

    public void HandleSliderValueChanged(float value)
    {
        _volumeValue = Mathf.Log10(value)* _multipyer;
        Mixer.SetFloat(volumeParameter, _volumeValue);
    }

    private void Start()
    {

        _volumeValue = PlayerPrefs.GetFloat(volumeParameter, Mathf.Log10(slider.value) * _multipyer);

        Mixer.SetFloat(volumeParameter, _volumeValue);
        slider.value = Mathf.Pow(10f, _volumeValue / _multipyer);
   
    }

    private void OnDisable()
    {
        PlayerPrefs.SetFloat(volumeParameter, _volumeValue);
    }
}
