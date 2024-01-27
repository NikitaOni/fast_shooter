using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using JUTPS.InventorySystem;
using JUTPS.ItemSystem;
using System;
using System.Runtime.InteropServices;

public class RewardedADS : MonoBehaviour
{
    public static bool m249 = false;
    public static bool machete = false;
    public static bool egle = false;
    public static bool infiniteAmmo = false;

    [Header("M249")]
    [SerializeField] GameObject active_m249;
    [SerializeField] GameObject done_m249;

    [Header("Ìachete")]
    [SerializeField] GameObject active_machete;
    [SerializeField] GameObject done_machete;

    [Header("DesertEgle")]
    [SerializeField] GameObject active_egle;
    [SerializeField] GameObject done_egle;

    [Header("InfiniteAmmo")]
    [SerializeField] GameObject active_ammo;
    [SerializeField] GameObject done_ammo;

    [DllImport("__Internal")]
    private static extern void Advertising();


    private void Start()
    {
        Advertising();
    }




    public void GetM249()
    {
        active_m249.SetActive(false);
        done_m249.SetActive(true);
        m249 = true;
    }
    public void GetÌachete()
    {
        active_machete.SetActive(false);
        done_machete.SetActive(true);
        machete = true;
    }
    public void GetEgle()
    {
        active_egle.SetActive(false);
        done_egle.SetActive(true);
        egle = true;
    }
    public void GetInfiniteAmmo()
    {
        active_ammo.SetActive(false);
        done_ammo.SetActive(true);
        infiniteAmmo = true;
    }

    public static void returnEquip()
    {
        m249 = false;
        machete = false;
        egle = false;
        infiniteAmmo = false;
    }
}
