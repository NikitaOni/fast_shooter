using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BartySpawn : MonoBehaviour
{
    [SerializeField] private GameObject Barty;

    [SerializeField] public Transform spawnPositionWest;
    [SerializeField] private Transform spawnPositionEast;
    [SerializeField] private Transform spawnPositionNorth;
    [SerializeField] private Transform spawnPositionSouth;


    

    // Update is called once per frame
    public void SpawnWest()
    {
        Instantiate(Barty, spawnPositionWest.transform.position, Quaternion.Euler(0f, 270f, 0f));
        
    }
    public void SpawnEast()
    {
        Instantiate(Barty, spawnPositionEast.transform.position, Quaternion.Euler(0f, 90f, 0f));
        
    }
    public void SpawnNorth()
    {
        Instantiate(Barty, spawnPositionNorth.transform.position, Quaternion.Euler(0f, 0f, 0f));
        
    }
    public void SpawnSouth()
    {
        Instantiate(Barty, spawnPositionSouth.transform.position, Quaternion.Euler(0f, 180f, 0f));
        
    }
}
