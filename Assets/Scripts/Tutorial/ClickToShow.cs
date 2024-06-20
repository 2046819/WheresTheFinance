using UnityEngine;
using UnityEngine.EventSystems;

public class ClickToShow : MonoBehaviour, IPointerClickHandler
{
    public GameObject objectToAppear;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Activate the object when clicked
        objectToAppear.SetActive(true);
    }
}
