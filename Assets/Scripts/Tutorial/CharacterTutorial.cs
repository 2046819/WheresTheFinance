using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTutorial : MonoBehaviour
{
    public GameObject imageToShow; // Reference to the GameObject containing the image

    private void OnMouseDown()
    {
        // Check if the image to show is not null
        if (imageToShow != null)
        {
            // Activate the GameObject containing the image
            imageToShow.SetActive(true);
        }
        else
        {
            Debug.LogWarning("Image to show is not assigned.");
        }
    }
}
