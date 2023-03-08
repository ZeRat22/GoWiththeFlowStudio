using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject deathEffect;

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Red Zombie")
        {
            Instantiate(deathEffect, transform.position, transform.rotation);

            FindObjectOfType<AudioManager>().Play("Death");

            Destroy(gameObject);
        }
    }
}
