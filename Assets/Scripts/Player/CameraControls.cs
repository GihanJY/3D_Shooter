using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    [SerializeField] private Transform TPP;
    [SerializeField] private Transform FPP;
    private bool isFPP = false;
    void Start()
    {
        Camera.main.transform.SetParent(TPP);
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.V))
        {
            isFPP = !isFPP;
        }
        if (isFPP)
        {
            changePerspective(FPP);
        }
        else
        {
            changePerspective(TPP);
        }
    }
    private void changePerspective(Transform perspective)
    {
        Camera.main.transform.SetParent (perspective);
        Camera.main.transform.position = perspective.position;
    }
}
