using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public bool canSpawn = true;
    public float enemySpawnTime = 0.5f;
    public float enemyMaxY = 4.5f;
    public float enemyStartingX = 10.0f;

    float enemyRandomY = 0f;

    private void Start()
    {
        StartCoroutine(EnemySpawn());
    }

    IEnumerator EnemySpawn()
    {
        while (canSpawn == true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }

    void SpawnEnemy()
    {
        enemyRandomY = Random.Range(-enemyMaxY, enemyMaxY);
        Instantiate(enemyToSpawn, new Vector3(enemyStartingX, enemyRandomY, 0), Quaternion.identity);
    }
}
