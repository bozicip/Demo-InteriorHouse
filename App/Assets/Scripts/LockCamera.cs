using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCamera : MonoBehaviour
{
    public Transform cameraPosition;
    private void Update()
    {
        transform.rotation = cameraPosition.rotation;
        transform.position = cameraPosition.position;
    }
}
