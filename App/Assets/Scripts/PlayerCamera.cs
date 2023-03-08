using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float senX;
    public float senY;

    public float cameraOffsetY;
    public Transform cameraHolder;
    public Transform Oriental;
    float xRotation;
    float yRotation;
    public CharacterController character;
    private void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        if (!UIManager.isLockAllControl)
        {
            float MouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * senX;
            float MouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * senY;

            yRotation += MouseX;
            xRotation -= MouseY;
            cameraHolder.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            Oriental.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        }
    }
}
