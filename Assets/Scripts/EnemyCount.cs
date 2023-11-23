using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour
{
    private void Awake()
    {
        LevelManager.enemyCount++;
    }

    public void decreaseCount()
    {
        LevelManager.enemyCount--;
    }
}
