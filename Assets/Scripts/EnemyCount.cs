using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyCount : MonoBehaviour
{
    private void Awake()
    {
        AddEnemyCount.enemyCount++;
    }

    public void decreaseCount()
    {
        AddEnemyCount.enemyCount--;
        if(AddEnemyCount.enemyCount == 0)
        {
            StartCoroutine(DeleyWin());
            
        }
    }

    private IEnumerator DeleyWin()
    {
        if (LevelCount.levelCount < 10)
        {
            LevelCount.levelCount++;
            PlayerPrefs.SetInt("Level", LevelCount.levelCount);
            RewardedADS.returnEquip();
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(0);
        }
        else
        {
            ThanksManager.gameEnd = 1;
            LevelCount.levelCount = 1;
            PlayerPrefs.SetInt("Level", LevelCount.levelCount);
            RewardedADS.returnEquip();
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(0);
        }
    }
    
}
