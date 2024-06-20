using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClueManager : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Sprite image1; // First image
    [SerializeField] private Sprite image2; // Second image
    [SerializeField] private GameObject instagramButton; // Button to open Instagram
    [SerializeField] private InstaObjectsManager interactableObject; // Reference to the interactable object
    private Image uiImage;
    private bool isInteractable = false;

    private void Awake()
    {
        uiImage = GetComponent<Image>();
        if (uiImage == null)
        {
            Debug.LogError("No Image component found on this GameObject.");
            return;
        }

        // Hide the Instagram button initially
        if (instagramButton != null)
        {
            instagramButton.SetActive(false);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (isInteractable)
        {
            // Toggle between image1 and image2
            uiImage.sprite = (uiImage.sprite == image1) ? image2 : image1;

            // Show the Instagram button when sprite 2 is visible
            if (uiImage.sprite == image2 && uiImage.sprite.name == "clueinsta" && instagramButton != null)
            {
                interactableObject.SetInteractable(true);
                Debug.Log("Interactable object set to interactable.");
                instagramButton.SetActive(true);
            }
            else
            {
                // Hide the Instagram button if sprite 2 is not visible
                instagramButton.SetActive(false);
            }
        }
    }

    public void SetInteractable(bool interactable)
    {
        isInteractable = interactable;
    }

    // Public method to change image2
    public void ChangeImage2(Sprite newSprite)
    {
        Debug.Log("Attempting to change image2 sprite.");

        // If the current sprite is already image2, update it immediately
        if (uiImage.sprite == image2)
        {
            uiImage.sprite = newSprite;
            Debug.Log("Changed ClueManager's image2 sprite to " + newSprite.name);
        }

        // Update the image2 variable regardless of whether it's the current sprite
        image2 = newSprite;

        // Show or hide the Instagram button based on the new image2
        if (uiImage.sprite == newSprite && newSprite.name == "clueinsta" && instagramButton != null)
        {
            instagramButton.SetActive(true);
        }
        else if (instagramButton != null)
        {
            instagramButton.SetActive(false);
        }
    }

    public void OnInstagramButtonClicked()
    {
        //Open Instagram
        Application.OpenURL("https://www.instagram.com/p/C7e3ufAosIY/?igsh=MWJhOWYzcWNobTdkMg==");
    }
}

