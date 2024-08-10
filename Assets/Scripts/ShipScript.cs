using UnityEngine;

public class ShipScript2 : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    private Rigidbody2D rb;

    void Start()
    {
        // Attempt to get the Rigidbody2D component if not assigned
        rb = GetComponent<Rigidbody2D>();

        // Ensure the Rigidbody2D component is found
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component not found on " + gameObject.name);
        }
    }

    void FixedUpdate()
    {
        // Ensure rb is not null before proceeding
        if (rb != null)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");  // Left and Right
            float moveVertical = Input.GetAxis("Vertical");  // Up and Down

            // Calculate movement
            Vector2 movement = new Vector2(moveHorizontal, moveVertical) * speed * Time.fixedDeltaTime;

            // Move the ship
            rb.MovePosition(rb.position + movement);
        }
    }
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Object"))
        {
            
            Destroy(collision.gameObject); // Optional: Destroy the object on collision
        }
    }
}
