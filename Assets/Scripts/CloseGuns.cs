using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class CloseGuns : MonoBehaviour
{
    [SerializeField] GameObject locked;
    // Start is called before the first frame update
    void Start()
    {
        if (RewardedADS.m249)
        {
            locked.SetActive(false);
        }
    }

}
