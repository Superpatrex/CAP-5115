using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera EnvironmentCamera;
    public Camera SpectatorCamera;
    private Camera CurrenCamera;

    private float oRotation = -90;
    private float fRotation = -90;
    // Start is called before the first frame update
    void Start()
    {
        EnvironmentCamera.enabled = false;
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
                fRotation += 45f * (Time.deltaTime);
                if (fRotation > 0)
                    fRotation = 0;
            }

            if (UnityEngine.Input.GetKey(KeyCode.RightArrow))
            {
                fRotation -= 45f * (Time.deltaTime);
                if (fRotation < -180)
                    fRotation = -180;
            }

            EnvironmentCamera.transform.position = Quaternion.Euler(0, fRotation, 0) * new Vector3(0, 1.5f, -3.5f);
            EnvironmentCamera.transform.rotation = Quaternion.LookRotation(SpectatorCamera.transform.position - EnvironmentCamera.transform.position + new Vector3(-2, 0, 0));
        }
    }
}
