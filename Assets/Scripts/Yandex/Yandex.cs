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


    public void RateGameButton()
    {
        Time.timeScale = 0;
        RateGame();
    }

    public void ADSRewardButtonDesertEgle()
    {
        Time.timeScale = 0;
        ADSRewardEgle(); 
    }

    public void GetEgle()
    {
        ADSManager.GetEgle();
    }

    public void ADSRewardButtonMachete()
    {
        Time.timeScale = 0;
        ADSRewardMachete();
    }

    public void GetÌachete()
    {
        ADSManager.GetÌachete();
    }

    public void ADSRewardButtonM249()
    {
        Time.timeScale = 0;
        ADSRewardM249();
    }

    public void GetM249()
    {
        ADSManager.GetM249();
    }

    public void ADSRewardButtonInfiniteAmmo()
    {
        Time.timeScale = 0;
        ADSRewardInfiniteAmmo();
    }

    public void GetInfiniteAmmo()
    {
        ADSManager.GetInfiniteAmmo();
    }

    public void getTimeScale()
    {
        Time.timeScale = 1;
    }
}

