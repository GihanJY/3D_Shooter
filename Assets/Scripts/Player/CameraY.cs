using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraY : MonoBehaviour
{
    private float mouseY;
    private float yAxis;
    [SerializeField] private float sensitivity;
    void Update()
    {
        mouseYBehavior();
    }
    private void mouseYBehavior()
    {
        mouseY = Input.GetAxis("Mouse Y");
        yAxis -= mouseY * sensitivity;
        yAxis = Mathf.Clamp(yAxis, -50, 50);
        transform.localEulerAngles = new Vector3(yAxis, 0, 0);
    }
}
