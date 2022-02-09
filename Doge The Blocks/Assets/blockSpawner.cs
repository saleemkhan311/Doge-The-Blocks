using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject Block;

    float spawnTime = 2;
    public float waveTime = 1f;
    void Update()
    {
        if (Time.time > spawnTime)
        {   
            Spawner();
            spawnTime = Time.time + waveTime;
        }

        if (Block.transform.position.y < -6)
        {
            Destroy(Block.gameObject);
        }

    }

   void Spawner()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(Block, spawnPoints[i].position, Quaternion.identity);
            }
        }

        
    }
}
