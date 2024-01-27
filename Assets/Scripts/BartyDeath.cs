using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BartyDeath : MonoBehaviour
{

    private IEnumerator DeleyDeath()
    {
        yield return new WaitForSeconds(2);
        AddEnemyCount.enemyCount = 0;
        RewardedADS.returnEquip();
        SceneManager.LoadScene(0);
    }
     public  void Death()
    {
        StartCoroutine(DeleyDeath());
    }
}
