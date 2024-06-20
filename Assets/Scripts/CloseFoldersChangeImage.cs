using UnityEngine;
using UnityEngine.UI;

public class CloseFoldersChangeImage : MonoBehaviour
{
    [SerializeField] private Image imageToChange;
    [SerializeField] private Sprite finishedGameSprite;
    [SerializeField] private Image Lock;

    private void Start()
    {
        if (gameState.GameFinished)
        {
            Debug.Log("Game is finished. Changing image.");
            Debug.Log("Game is finished. Changing image alpha to 255.");
            Color newColor = imageToChange.color;
            newColor.a = 1f; // Set alpha to 255 (1 in normalized float)
            imageToChange.color = newColor;
            Lock.enabled = false;
        }
        else
        {
            Debug.Log("Game is not finished. Keeping default image.");
        }
    }
}
