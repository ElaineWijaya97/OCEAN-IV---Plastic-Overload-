using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobject : MonoBehaviour
{
     public GameObject objectprefab; // The object prefab to spawn
    public Vector2 areaSize = new Vector2(10, 10); // Dimensions of the area to spawn object
    public int numberOfObject = 10; // Number of enemies to spawn

    private void Start()
    {
        SpawnEnemies();
    }

    private void SpawnEnemies()
    {
        for (int i = 0; i < numberOfObject; i++)
        {
            Vector3 spawnPosition = GetRandomPosition();
            Instantiate(objectprefab, spawnPosition, Quaternion.identity);
        }
    }

    private Vector3 GetRandomPosition()
    {
        float x = Random.Range(-areaSize.x / 2, areaSize.x / 2);
        float y = Random.Range(-areaSize.y / 2, areaSize.y / 2);
        return new Vector3(x, y, 0) + transform.position;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(areaSize.x,areaSize.y , 1));
    }
}

