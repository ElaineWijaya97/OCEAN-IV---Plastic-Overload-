using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killscript : MonoBehaviour
{
    Vector2 startingPosition;
    public GameObject Checkpoint;
    public GameObject player;

    private void Start()
    {
        player.SetActive(true);
        Checkpoint.SetActive(false);
        startingPosition = transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bottle") || collision.CompareTag("enemy"))
        {
            Die();
        }
        if(collision.CompareTag("Checkpoint")) {
            Checkpoint.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
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
    void switchCamera(){
        player.SetActive(false);
        Checkpoint.SetActive(true);
        Destroy(player);
    }
}
