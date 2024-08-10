using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottle") || collision.CompareTag("enemy"))
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}