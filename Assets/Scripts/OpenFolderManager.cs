using UnityEngine;
using UnityEngine.UI;

public class OpenFolderMana : MonoBehaviour
{
    [SerializeField] private Sprite newImage; // New image to be displayed
    [SerializeField] private Image targetImage; // Reference to the Image component whose image will be changed
    private bool hasChanged = false; // Flag to track whether the image has been changed

    public void ChangeImage()
    {
        // Check if the target Image component is assigned and the image has not been changed yet
        if (targetImage != null && !hasChanged)
        {
            // Change the source image of the target Image component
            targetImage.sprite = newImage;
            // Set the flag to true to indicate that the image has been changed
            hasChanged = true;
        }
    }
}

