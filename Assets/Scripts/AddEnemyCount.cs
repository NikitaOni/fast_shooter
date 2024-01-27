using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddEnemyCount : MonoBehaviour
{
    public static int enemyCount;

    [SerializeField] private Text counter;


    private void Update()
    {
        counter.text = enemyCount.ToString();
    }

}
