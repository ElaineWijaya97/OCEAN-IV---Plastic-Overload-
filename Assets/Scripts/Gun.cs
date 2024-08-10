using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
 void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpawnPoint.right.x, bulletSpawnPoint.right.y) * bulletSpeed;
    }
}
}