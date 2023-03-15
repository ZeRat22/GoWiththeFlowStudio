using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<EnemyMovement>())
        {
            PlayerScore._currentScore++;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
