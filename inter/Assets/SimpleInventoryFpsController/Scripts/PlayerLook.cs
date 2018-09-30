using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour {

    public float mouseSensitivity;
    public Transform PlayerBody;

    float xAxisClamp;

    private void Start()
    {
        xAxisClamp = 0;
    }

    void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        LockCursor();
        CameraRotation();
    }

    void CameraRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xAxisClamp += mouseY;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 90;
            mouseY = 0;
            ClampXAxisRotationToValue(270);
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -90;
            mouseY = 0;
            ClampXAxisRotationToValue(90);
        }
        
        transform.Rotate(Vector3.left * mouseY);
        PlayerBody.Rotate(Vector3.up * mouseX);
    }

    void ClampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
