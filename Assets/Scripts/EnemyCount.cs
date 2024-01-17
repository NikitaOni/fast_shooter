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
            StartCoroutine(DeleyWin());
            
        }
    }

    private IEnumerator DeleyWin()
    {
        if (LevelCount.levelCount < 10)
        {
            LevelCount.levelCount++;
            RewardedADS.returnEquip();
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(0);
        }
        else
        {
            ThanksManager.gameEnd = 1;
            LevelCount.levelCount = 1;
            RewardedADS.returnEquip();
            yield return new WaitForSeconds(1.5f);
            SceneManager.LoadScene(0);
        }
    }
    
}
