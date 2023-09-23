using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject projectile;
    public float playerSpeed = 3.0f;

    public float maxPlayerX = 8.0f;
    public float maxPlayerY = 4.5f;

    public float playerCollisionOffset = 0.8f;

    private void Update()
    {
        PlayerMovement(); 
        SpawnProjectileOnKey();
    }

    private void FixedUpdate()
    {
        
    }

    private void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y <= maxPlayerY)
        {
            transform.Translate(0, playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -maxPlayerX)
        {
            transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -maxPlayerY)
        {
            transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= maxPlayerX)
        {
            transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
        }
    }

    private void SpawnProjectileOnKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnProjectile();
        }
    }

    private void SpawnProjectile() //bu ne nee
    {
        Instantiate(projectile, new Vector3(transform.position.x + playerCollisionOffset, transform.position.y, 0), Quaternion.identity);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("SpaceShooterSideways");
        }
    }

}
