using UnityEngine;

public class ShipScript : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float rotationSpeed = 100f; // Speed at which the ship rotates
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
            // Get input for movement
            float moveHorizontal = Input.GetAxis("Horizontal"); // Left and Right
            float moveVertical = Input.GetAxis("Vertical"); // Up and Down

            // Calculate movement
            Vector2 movement = new Vector2(moveHorizontal, moveVertical) * speed * Time.fixedDeltaTime;

            // Move the ship
            rb.MovePosition(rb.position + movement);

            // Determine if movement is diagonal
            bool isDiagonal = (moveHorizontal != 0 && moveVertical != 0);

            if (isDiagonal)
            {
                // Calculate the target angle based on movement direction
                float angle = Mathf.Atan2(moveVertical, moveHorizontal) * Mathf.Rad2Deg;

                // Apply rotation
                rb.rotation = angle; // Set the rotation to face the movement direction
            }
        }
    }
}
