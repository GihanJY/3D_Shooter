using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraX : MonoBehaviour
{
    private float mouseX;
    private Vector3 rotation;
    [SerializeField] private float sensitivity;
    void Update()
    {
        mouseXBehavior();
    }
    private void mouseXBehavior()
    {
        mouseX = Input.GetAxis("Mouse X");
        rotation = transform.localEulerAngles;
        rotation.y += mouseX * sensitivity;
        transform.localEulerAngles = rotation;
    }
}
