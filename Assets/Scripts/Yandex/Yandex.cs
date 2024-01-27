using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Yandex : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void RateGame();

    [DllImport("__Internal")]
    private static extern void ADSRewardEgle();

    [DllImport("__Internal")]
    private static extern void ADSRewardMachete();

    [DllImport("__Internal")]
    private static extern void ADSRewardM249();

    [DllImport("__Internal")]
    private static extern void ADSRewardInfiniteAmmo();

    [SerializeField] private RewardedADS ADSManager;
    [SerializeField] public AudioSource music;


    public void RateGameButton()
    {
        RateGame();
    }

    public void ADSRewardButtonDesertEgle()
    {
        music.Pause();
        ADSRewardEgle(); 
    }

    public void GetEgle()
    {
        ADSManager.GetEgle();
    }

    public void ADSRewardButtonMachete()
    {
        music.Pause();
        ADSRewardMachete();
    }

    public void GetÌachete()
    {
        ADSManager.GetÌachete();
    }

    public void ADSRewardButtonM249()
    {
        music.Pause();
        ADSRewardM249();
    }

    public void GetM249()
    {
        ADSManager.GetM249();
    }

    public void ADSRewardButtonInfiniteAmmo()
    {
        music.Pause();
        ADSRewardInfiniteAmmo();
    }

    public void GetInfiniteAmmo()
    {
        ADSManager.GetInfiniteAmmo();
    }

    public void MusicPlay()
    {
        music.Play();
    }

}

