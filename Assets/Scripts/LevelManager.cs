using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour

{
    [SerializeField] public Material SkyboxOne;
    [SerializeField] public Material SkyboxTwo;
    [SerializeField] public Material SkyboxThree;
    [SerializeField] public Material SkyboxFour;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip FonkOne;
    [SerializeField] private AudioClip FonkTwo;
    [SerializeField] private AudioClip FonkThree;
    [SerializeField] private AudioClip FonkFour;

    [SerializeField] private BartySpawn bartySpawn;


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
                bartySpawn.SpawnSouth();
                audioSource.clip = FonkOne;
                audioSource.Play();
                RenderSettings.skybox = SkyboxOne;
                Instantiate(level_1);
                break;
            case 2:
                bartySpawn.SpawnSouth();
                audioSource.clip = FonkOne;
                audioSource.Play();
                RenderSettings.skybox = SkyboxOne;
                Instantiate(level_2);
                break;
            case 3:
                bartySpawn.SpawnEast();
                audioSource.clip = FonkTwo;
                audioSource.Play();
                RenderSettings.skybox = SkyboxTwo;
                Instantiate(level_3);
                break;
            case 4:
                bartySpawn.SpawnEast();
                audioSource.clip = FonkTwo;
                audioSource.Play();
                RenderSettings.skybox = SkyboxTwo;
                Instantiate(level_4);
                break;
            case 5:
                bartySpawn.SpawnWest();
                audioSource.clip = FonkThree;
                audioSource.Play();
                RenderSettings.skybox = SkyboxThree;
                Instantiate(level_5);
                break;
            case 6:
                bartySpawn.SpawnWest();
                audioSource.clip = FonkThree;
                audioSource.Play();
                RenderSettings.skybox = SkyboxThree;
                Instantiate(level_6);
                break;
            case 7:
                bartySpawn.SpawnWest();
                audioSource.clip = FonkThree;
                audioSource.Play();
                RenderSettings.skybox = SkyboxThree;
                Instantiate(level_7);
                break;
            case 8:
                bartySpawn.SpawnNorth();
                audioSource.clip = FonkFour;
                audioSource.Play();
                RenderSettings.skybox = SkyboxFour;
                Instantiate(level_8);
                break;
            case 9:
                bartySpawn.SpawnNorth();
                audioSource.clip = FonkFour;
                audioSource.Play();
                RenderSettings.skybox = SkyboxFour;
                Instantiate(level_9);
                break;
            case 10:
                bartySpawn.SpawnNorth();
                audioSource.clip = FonkFour;
                audioSource.Play();
                RenderSettings.skybox = SkyboxFour;
                Instantiate(level_10);
                break;
        }
    }

}
