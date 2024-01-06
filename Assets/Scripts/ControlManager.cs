using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlManager : MonoBehaviour
{

    [SerializeField] private GameObject control;
    public void Show()
    {
        control.SetActive(true);
    }
    public void Hide()
    {
        control.SetActive(false);
    }
}
