using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Clue1Toogle : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Sprite image1; // First image
    [SerializeField] private Sprite image2; // Second image

    private Image uiImage;
    private bool isImage1 = true;

    private void Awake()
    {
        uiImage = GetComponent<Image>();
        if (uiImage == null)
        {
            Debug.LogError("No Image component found on this GameObject.");
        }
        else
        {
            // Set the initial image
            uiImage.sprite = image1;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // Toggle between image1 and image2
        uiImage.sprite = isImage1 ? image2 : image1;
        isImage1 = !isImage1;
    }
}
