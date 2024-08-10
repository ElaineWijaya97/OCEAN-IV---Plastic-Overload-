using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shiprotation : MonoBehaviour
{
    // Start is called before the first frame update
 [SerializeField] private float speed = 10f;
    [SerializeField] private float rotationSpeed = 100f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on " + gameObject.name);
        }
    }

    void Update()
    {
        RotateShipTowardsMouse();
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            MoveShip();
        }
    }

    void MoveShip()
    {
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = transform.up * moveVertical * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }

    void RotateShipTowardsMouse()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = (Vector2)(mousePos - transform.position);
        direction.Normalize();

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

}
