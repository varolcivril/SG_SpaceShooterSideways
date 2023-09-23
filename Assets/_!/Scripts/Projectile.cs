using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float projectileSpeed = 1.0f;

    private void Update()
    {
        MoveProjectileRight();
        ProjectileGone();
    }

    private void MoveProjectileRight()
    {
        transform.Translate(projectileSpeed * Time.deltaTime, 0, 0);
    }

    private void ProjectileGone()
    {
        if (gameObject.transform.position.x >= 15)
        {
            Destroy(gameObject);
        }
    }
}
