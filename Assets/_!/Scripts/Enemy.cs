using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed = 2.0f;

    void Update()
    {
        MoveEnemyLeft();
        EnemyGone();
    }

    private void MoveEnemyLeft()
    {
        transform.Translate(-enemySpeed * Time.deltaTime, 0, 0);
    }

    private void EnemyGone()
    {
        if (gameObject.transform.position.x <= -15)
        {
            Destroy(gameObject);
        }
    }
}
