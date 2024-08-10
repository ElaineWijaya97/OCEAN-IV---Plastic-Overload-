using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScriptBottle : MonoBehaviour
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
        Destroy(gameObject);
    }
}
