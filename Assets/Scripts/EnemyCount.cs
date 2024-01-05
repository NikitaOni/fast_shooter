using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyCount : MonoBehaviour
{
    private void Awake()
    {
        LevelManager.enemyCount++;
    }

    public void decreaseCount()
    {
        LevelManager.enemyCount--;
        if(LevelManager.enemyCount == 0)
        {
            LevelCount.levelCount++;
            SceneManager.LoadScene(0);
        }
    }
}
