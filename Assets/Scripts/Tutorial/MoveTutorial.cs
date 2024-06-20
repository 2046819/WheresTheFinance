using System.Collections;
using UnityEngine;

public class MoveTutorial : MonoBehaviour
{
    [SerializeField] private GameObject objectToMakeVisible;

    private bool objectsVisible = true;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && objectsVisible)
        {
            Debug.Log("The objects will be destroyed in 3 Seconds");
            StartCoroutine(DisappearObjects());
        }
    }

    private IEnumerator DisappearObjects()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject); // Destroy all objects
        }
        objectsVisible = false;

        // Make the zoom tutorial visible
        objectToMakeVisible.SetActive(true);
    }
}