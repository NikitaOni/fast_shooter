using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour

{
    public static int enemyCount;

    [SerializeField] private Text counter;

    [Header("Level Number")]
    [SerializeField] GameObject level_1;
    [SerializeField] GameObject level_2;
    [SerializeField] GameObject level_3;
    [SerializeField] GameObject level_4;
    [SerializeField] GameObject level_5;
    [SerializeField] GameObject level_6;
    [SerializeField] GameObject level_7;
    [SerializeField] GameObject level_8;
    [SerializeField] GameObject level_9;
    [SerializeField] GameObject level_10;

    private void Start()
    {
        switch (LevelCount.levelCount)
        {
            case 1:
                Instantiate(level_1);
                break;
            case 2:
                Instantiate(level_2);
                break;
            case 3:
                Instantiate(level_3);
                break;
            case 4:
                Instantiate(level_4);
                break;
            case 5:
                Instantiate(level_5);
                break;
            case 6:
                Instantiate(level_6);
                break;
            case 7:
                Instantiate(level_7);
                break;
            case 8:
                Instantiate(level_8);
                break;
            case 9:
                Instantiate(level_9);
                break;
            case 10:
                Instantiate(level_10);
                break;
        }
    }

    private void Update()
    {
        counter.text = enemyCount.ToString();
    }
}
