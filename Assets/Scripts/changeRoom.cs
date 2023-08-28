using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRoom : MonoBehaviour
{
    public Vector2 cameraShiftMin;
    public Vector2 cameraShiftMax;
    public Vector3 playerShift;
    private CameraMovement cam;

    void Start() // gets camera
    {
        cam = Camera.main.GetComponent<CameraMovement>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D player) // if the player changes rooms this shifts the camera's boudnaries.
    {
        if (player.CompareTag("Player"))
        {
            cam.minPosition = cameraShiftMin;
            cam.maxPosition = cameraShiftMax;
            player.transform.position += playerShift;
        }
    }
}
