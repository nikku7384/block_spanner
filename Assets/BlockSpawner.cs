using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public Transform[] spawnpoints;
    public GameObject blockPrefeb;
    public float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;



    void Update() {

        if (Time.time >= timeToSpawn) {

            spawnBlock();

            timeToSpawn = Time.time + timeBetweenWaves;

        }
    }

   

    void spawnBlock()
    {
        int randomIndex = Random.Range(0, spawnpoints.Length);

        for (int i = 0; i < spawnpoints.Length; i++)
        {
            if (randomIndex != i) {

                Instantiate(blockPrefeb, spawnpoints[i].position, Quaternion.identity);

            }
        }
    }

    
}
