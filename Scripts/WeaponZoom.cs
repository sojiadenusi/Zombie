using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;

    [Header("ADS settings")]
    [SerializeField] float zoomInFOV = 20f;
    [SerializeField] float zoomOutFOV = 60f;

    [Header("ADS Mouse Sensitivity")]
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 1f;

    bool zoomInToggle = false;

    private void OnDisable()
    {
        ZoomOut();
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }


        }
    }

   
    private void ZoomOut()
    {        
        zoomInToggle = false;
        mainCamera.fieldOfView = zoomOutFOV;
        fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
    }

    private void ZoomIn()
    {
        zoomInToggle = true;
        mainCamera.fieldOfView = zoomInFOV;
        fpsController.mouseLook.XSensitivity = zoomInSensitivity;
        fpsController.mouseLook.YSensitivity = zoomInSensitivity;
    }

}
