using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    private int health = 5;

    private Material matWhite;
    private Material matDefault;

    private UnityEngine.Object explosionRef;
    private UnityEngine.Object enemyRef;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        enemyRef = Resources.Load("Red Zombie");
        spriteRenderer = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = spriteRenderer.material;
        explosionRef = Resources.Load("Explosion");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pizza"))
        {
            Destroy(collision.gameObject);
            health--;
            spriteRenderer.material = matWhite;

            if (health <= 0)
            {
                KillSelf();
            }
            else
            {
                Invoke("ResetMaterial", 0.1f);
            }
        }
    }

    void ResetMaterial()
    {
        spriteRenderer.material = matDefault;
    }

    private void KillSelf()
    {
        GameObject explosion = (GameObject)Instantiate(explosionRef);
        explosion.transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);
        
        spriteRenderer.enabled = false;
        Invoke("Respawn", 5);
    }

    void Respawn()
    {
        GameObject enemyClone = (GameObject)Instantiate(enemyRef);
        enemyClone.transform.position = transform.position;

        Destroy(gameObject);
    }
}
