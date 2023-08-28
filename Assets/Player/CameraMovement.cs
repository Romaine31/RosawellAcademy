using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    public float smoothing;
    public cameraVectors startingBoundary;
    void Start()
    {
        minPosition = startingBoundary.initialMinValue;
        maxPosition = startingBoundary.initialMaxValue; // sets initial camera boundary based off last saved values
    }

    void LateUpdate()
    {
        if (transform.position != target.position) // this function limits where the camera can go.
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);

            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPosition.y); // these two bounds the camera to the boundary

            transform.position = Vector3.Lerp(transform.position, targetPosition,smoothing);
        }
    }
}
