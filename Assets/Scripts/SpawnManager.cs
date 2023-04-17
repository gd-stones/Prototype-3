using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    void SpawnObstacle()
    {
        Vector3 spawnPos = new Vector3(30, 0, 0);
        int index = Random.Range(0, obstaclePrefabs.Length);

        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs[index], spawnPos, obstaclePrefabs[index].transform.rotation);
        }
    }
}