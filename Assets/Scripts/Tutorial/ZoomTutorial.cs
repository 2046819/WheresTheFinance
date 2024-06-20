using System.Collections;
using UnityEngine;

public class ZoomTutorial : MonoBehaviour
{
    [SerializeField] private GameObject objectToMakeVisible;
    private bool zoomObjectsVisible = true;

    private void Update()
    {
        // Check for scroll wheel input
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if (scroll != 0 && zoomObjectsVisible)
        {
            Debug.Log("The objects will be destroyed in 3 Seconds");
            StartCoroutine(DisappearZoomObjects());
        }
    }

    private IEnumerator DisappearZoomObjects()
    {
        yield return new WaitForSeconds(2f); // Wait for 2 seconds
        foreach (Transform child in transform)
        {
            Destroy(child.gameObject); // Destroy all objects
        }
        zoomObjectsVisible = false;

        objectToMakeVisible.SetActive(true);
    }
}