using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera EnvironmentCamera;
    public Camera SpectatorCamera;
    private Camera CurrenCamera;

    public Transform target; // The object around which the camera will rotate
    public float rotationSpeed = 50f;

    private float distance = 3.5f; // Distance from the target
    private float currentAngle = 0f;

    // Start is called before the first frame update
    void Start()
    {
        EnvironmentCamera.enabled = true;
        CurrenCamera = SpectatorCamera;
        SpectatorCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha1))
        {
            CurrenCamera = EnvironmentCamera;
            CurrenCamera.enabled = true;
        }

        if (UnityEngine.Input.GetKeyDown(KeyCode.Alpha2))
        {
            CurrenCamera.enabled = false;
            CurrenCamera = SpectatorCamera;
            CurrenCamera.enabled = true;
        }

        if (EnvironmentCamera.enabled)
        {
           if (UnityEngine.Input.GetKey(KeyCode.LeftArrow))
            {
                currentAngle += rotationSpeed * Time.deltaTime;
            }

            if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
            {
               currentAngle -= rotationSpeed * Time.deltaTime;
            }
            // Calculate the camera's position based on the current angle
            Vector3 offset = Quaternion.Euler(0, currentAngle, 0) * new Vector3(0, 0, -distance);
            transform.position = target.position + offset;

            // Make the camera look at the target
            transform.LookAt(target);
        }
    }
}
