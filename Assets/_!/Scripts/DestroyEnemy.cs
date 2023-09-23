using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    //public GameObject particles;
    //public GameObject particlesWhite;

    Score addToScore;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            CallScoreScript();
            //SpawnParticles(collision.transform.position);
            Destroy(collision.gameObject);
            Destroy(gameObject);

        }    
    }

    //void SpawnParticles(Vector2 tempPosition)
    //{
    //    Instantiate(particles, tempPosition, Quaternion.identity);
    //    Instantiate(particlesWhite, tempPosition, Quaternion.identity);
    //}

    void CallScoreScript()
    {
        addToScore = GameObject.FindGameObjectWithTag("GUI").GetComponent<Score>();
        addToScore.AddToScoreVoid();
    }
}
