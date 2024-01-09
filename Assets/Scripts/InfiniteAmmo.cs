using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JUTPS.WeaponSystem;

public class InfiniteAmmo : MonoBehaviour
{

    [Header("Weapon")]
    [SerializeField] Weapon Glock17;
    [SerializeField] Weapon MP7;
    [SerializeField] Weapon M16;
    [SerializeField] Weapon Benelli;
    [SerializeField] Weapon M249;
    [SerializeField] Weapon DesertEgle;

    [SerializeField] GameObject locked;

    void Start()
    {
        if (RewardedADS.infiniteAmmo)
        {
            Glock17.InfiniteAmmo = true;
            MP7.InfiniteAmmo = true;
            M16.InfiniteAmmo = true;
            Benelli.InfiniteAmmo = true;
            M249.InfiniteAmmo = true;
            DesertEgle.InfiniteAmmo = true;
        } 

        if (RewardedADS.m249) 
        {
            locked.SetActive(false);
        }
    }
}
