using UnityEngine;
using UnityEngine.UI;

public class Mario : MonoBehaviour
{
    [SerializeField] private Image targetImage; // Image component to change
    [SerializeField] private Sprite newSprite; // New sprite to set

    private MarioClickManager clickManager; // Reference to the click manager
    private bool isClickable = false; // Flag to determine if this character is clickable

    private void Start()
    {

    }

    public void SetClickManager(MarioClickManager manager)
    {
        clickManager = manager; // Set the click manager reference
    }

    public void SetClickable(bool clickable)
    {
        isClickable = clickable; // Enable or disable clicking for this character
    }

    private void OnMouseDown()
    {
        if (isClickable)
        {
            // Notify the ClickManager that this character was clicked
            clickManager.OnCharacterClicked(this);

            //Change the sprite
            ChangeImage();
        }
    }

    private void ChangeImage()
    {
        // If the target Image component exists, change its sprite
        if (targetImage != null)
        {
            targetImage.sprite = newSprite;
        }
        else
        {
            Debug.LogWarning("No Image component assigned as targetImage.");
        }
    }
}


