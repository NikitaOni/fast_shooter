using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour

{
    public static int enemyCount;

    [SerializeField] private Text counter;
    [SerializeField] public Material SkyboxOne;
    [SerializeField] public Material SkyboxTwo;
    [SerializeField] public Material SkyboxThree;

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
                RenderSettings.skybox = SkyboxOne;
                Instantiate(level_1);
                break;
            case 2:
                RenderSettings.skybox = SkyboxOne;
                Instantiate(level_2);
                break;
            case 3:
                RenderSettings.skybox = SkyboxTwo;
                Instantiate(level_3);
                break;
            case 4:
                RenderSettings.skybox = SkyboxTwo;
                Instantiate(level_4);
                break;
            case 5:
                RenderSettings.skybox = SkyboxTwo;
                Instantiate(level_5);
                break;
            case 6:
                RenderSettings.skybox = SkyboxTwo;
                Instantiate(level_6);
                break;
            case 7:
                RenderSettings.skybox = SkyboxThree;
                Instantiate(level_7);
                break;
            case 8:
                RenderSettings.skybox = SkyboxThree;
                Instantiate(level_8);
                break;
            case 9:
                RenderSettings.skybox = SkyboxThree;
                Instantiate(level_9);
                break;
            case 10:
                RenderSettings.skybox = SkyboxThree;
                Instantiate(level_10);
                break;
        }
    }

    private void Update()
    {
        counter.text = enemyCount.ToString();
    }
}
