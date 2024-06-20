using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FolderManager : MonoBehaviour
{
    [SerializeField] private GameObject imageToShow;
    [SerializeField] private GameObject secondImageToShow;
    [SerializeField] private GameObject thirdImageToShow;
    [SerializeField] private GameObject folderFinalImage;
    [SerializeField] private CameraMovement cameraMovement;
    [SerializeField] private GameObject Notification;

    public void ShowImage()
    {
        Notification.SetActive(false);
        imageToShow.SetActive(true);
        cameraMovement.enabled = false; // Disable the CameraMovement script

        // Get the Image component
        Image imageComponent = folderFinalImage.GetComponent<Image>();

        // Check if the Image component exists
        if (imageComponent != null)
        {
            // Check the name of the sprite
            if (imageComponent.sprite != null && imageComponent.sprite.name == "mario6")
            {
                Debug.Log("Image sprite is named mario6");
                gameState.GameFinished = true;
                StartCoroutine(ShowImageForSeconds(5f));
            }
        }
        else
        {
            Debug.LogWarning("Image component not found on folderFinalImage GameObject.");
        }
    }

    IEnumerator ShowImageForSeconds(float duration)
    {
        yield return new WaitForSeconds(duration);

        imageToShow.SetActive(false);
        secondImageToShow.SetActive(true);

        yield return new WaitForSeconds(3f);

        secondImageToShow.SetActive(false);
        thirdImageToShow.SetActive(true);

        yield return new WaitForSeconds(4f);

        SceneManager.LoadScene("FoldersBeginning");
    }

    public void HideImage()
    {
        imageToShow.SetActive(false);
        secondImageToShow.SetActive(false);
        thirdImageToShow.SetActive(false);
        cameraMovement.enabled = true; // Enable the CameraMovement script
    }
}
