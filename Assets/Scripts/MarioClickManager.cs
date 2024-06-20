using UnityEngine;
using UnityEngine.UI;

public class MarioClickManager : MonoBehaviour
{
    private int currentIndex = 0; // The current index of the clickable character

    public Mario[] characters; // An array to hold the characters
    public ClueManager[] clues; // An array to hold the clue scripts that are activated sequentially
    [SerializeField] private GameObject[] LockedClues;
    public ClueManager alwaysAvailableClue; // The clue that should be available from the start
    public GameObject Notification;

    //public HappinessMeter happinessMeter; // Reference to the HappinessMeter script

    void Start()
    {
        // Initialize all characters to be non-clickable except the first one
        for (int i = 0; i < characters.Length; i++)
        {
            characters[i].SetClickManager(this);  // Set the click manager for each character
            characters[i].SetClickable(i == currentIndex); // Only the first character is clickable initially
        }

        // Initialize only the clues in the array to be inactive logically
        foreach (ClueManager clue in clues)
        {
            clue.SetInteractable(false);
        }

        // Make the always available clue interactable from the start
        if (alwaysAvailableClue != null)
        {
            alwaysAvailableClue.SetInteractable(true);
        }
    }
    // Method to handle when a character is clicked
    public void OnCharacterClicked(Mario clickedCharacter)
    {
        Notification.SetActive(true);

        // Ensure the clicked character is the correct one in sequence
        if (clickedCharacter == characters[currentIndex])
        {
            // Activate the corresponding clue logic
            if (currentIndex < clues.Length)
            {
                clues[currentIndex].SetInteractable(true);
                LockedClues[currentIndex].SetActive(false);
            }

            // Change the layer of the clicked character to "Correct"
            clickedCharacter.gameObject.layer = LayerMask.NameToLayer("Correct");

            // Set the current character to non-clickable
            clickedCharacter.SetClickable(false);

            // Change the layer of the previous character back to "Default"
            if (currentIndex > 0)
            {
                characters[currentIndex - 1].gameObject.layer = LayerMask.NameToLayer("Wrong");
            }

            // Increment the index to make the next character clickable
            currentIndex++;

            // Ensure the index is within bounds
            if (currentIndex < characters.Length)
            {
                // Set the layer of the next character to "Correct"
                characters[currentIndex].gameObject.layer = LayerMask.NameToLayer("Correct");

                // Make the next character clickable
                characters[currentIndex].SetClickable(true);
            }
        }
    }
}