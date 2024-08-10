using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScriptEnemy : MonoBehaviour
{
    Vector2 startingPosition;

    private void Start()
    {
        startingPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            Die();
        }
    }

    void Die()
    {
        Respawn();
    }

    void Respawn()
    {
        transform.position = startingPosition;
    }
}