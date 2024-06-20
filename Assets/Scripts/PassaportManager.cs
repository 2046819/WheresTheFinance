using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassaportManager : MonoBehaviour
{
    [SerializeField]
    private GameObject imageToShow;
    [SerializeField]
    private CameraMovement cameraMovement;

    public void ShowImage()
    {
        imageToShow.SetActive(true);
        cameraMovement.enabled = false; // Disable the CameraMovement script
    }

    public void HideImage()
    {
        imageToShow.SetActive(false);
        cameraMovement.enabled = true; // Enable the CameraMovement script
    }
}
