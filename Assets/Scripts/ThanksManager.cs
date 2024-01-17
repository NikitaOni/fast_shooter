using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThanksManager : MonoBehaviour
{
    [SerializeField] private GameObject Thanks;

    public static int gameEnd = 0;

    private void Start()
    {
        if(gameEnd == 1)
        {
            Thanks.SetActive(true);
            gameEnd = 0;
        }
    }

    public void Hide()
    {
        Thanks.SetActive(false);
    }
}
