using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerCamera;
    public Vector2 sensitivities;
    public Vector2 XYRotation;
    float rotationX = 0f;
    float rotationY = 0f;
    public float sensitivity = 15f;
    

    // Update is called once per frame
    void Update()
    {
        Vector2 MouseInput = new Vector2
        {
            x = Input.GetAxis("Mouse X"),
            y = Input.GetAxis("Mouse Y")
        };
        XYRotation.x -= MouseInput.y * sensitivities.y;
        XYRotation.y += MouseInput.x * sensitivities.x;
        XYRotation.x = Mathf.Clamp(XYRotation.x, -90f, 90f);
        transform.eulerAngles = new Vector3(0f, XYRotation.y, 0f);
        playerCamera.localEulerAngles = new Vector3(XYRotation.x, 0f, 0f);

        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") *-1* sensitivity;
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);

    }
}
