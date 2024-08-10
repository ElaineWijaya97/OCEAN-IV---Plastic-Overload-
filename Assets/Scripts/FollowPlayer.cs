using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target; // The target object to follow
    public Vector2 offset;   // Optional offset from the target

    void Update()
    {
        // Ensure the target is assigned
        if (target != null)
        {
            // Update the follower's position to follow the target, with the specified offset
            Vector2 targetPosition = (Vector2)target.position + offset;
            transform.position = new Vector2(targetPosition.x, targetPosition.y);
        }
    }
}
