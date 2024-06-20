using UnityEngine;

public class InstaObjectsManager : MonoBehaviour
{
    [SerializeField] private ClueManager targetClueManager; // Reference to the specific ClueManager
    [SerializeField] private Sprite newSpriteForImage2; // New sprite for image2
    [SerializeField] private GameObject Notification;
    private bool isInteractable = false;

    private void OnMouseDown()
    {
        if (isInteractable)
        {
            // Ensure the ClueManager reference and new sprite are set
            if (targetClueManager != null && newSpriteForImage2 != null)
            {
                targetClueManager.ChangeImage2(newSpriteForImage2);
                Debug.Log("Changed ClueManager's image2 sprite to " + newSpriteForImage2.name);
                Notification.SetActive(true);
            }
            else
            {
                Debug.LogWarning("Target ClueManager reference or newSpriteForImage2 is not set.");
            }
        }
    }

    public void SetInteractable(bool interactable)
    {
        isInteractable = interactable;
        Debug.Log("InteractableObject is now " + (interactable ? "interactable" : "not interactable"));
    }
}
