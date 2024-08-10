using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeInvisible : MonoBehaviour
{
    // Start is called before the first frame update
        public GameObject ugcObject;

    void Start()
    {
        if (ugcObject != null)
        {
            // Find the Camera component on the UGC GameObject
            Camera camera = ugcObject.GetComponent<Camera>();

            if (camera != null)
            {
                // Create a new GameObject to hold the Camera
                GameObject cameraHolder = new GameObject("CameraHolder");

                // Set the new GameObject's position and rotation to match the original
                cameraHolder.transform.position = camera.transform.position;
                cameraHolder.transform.rotation = camera.transform.rotation;

                // Detach the Camera component from the UGC GameObject
                camera.transform.parent = cameraHolder.transform;
            }

            // Destroy the UGC GameObject
            Destroy(ugcObject);
        }
        else
        {
            Debug.LogWarning("UGC GameObject is not assigned.");
        }
    }

}
