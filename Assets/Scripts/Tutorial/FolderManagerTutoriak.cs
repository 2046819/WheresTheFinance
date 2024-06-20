using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FolderManagerTutoriak : MonoBehaviour
{
    [SerializeField] private GameObject imageToShow;
    [SerializeField] private CameraMovement cameraMovement;
    [SerializeField] private GameObject imageToHide;

    public void ShowImage()
    {
        imageToShow.SetActive(true);
        imageToHide.SetActive(false);
        cameraMovement.enabled = false; // Disable the CameraMovement script
    }

    public void HideImage()
    {
        imageToShow.SetActive(false);
        cameraMovement.enabled = true; // Enable the CameraMovement script
    }
}
