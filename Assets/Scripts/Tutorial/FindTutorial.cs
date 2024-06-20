using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FindTutorial : MonoBehaviour, IPointerClickHandler
{
    public GameObject objectDisapear;
    public GameObject objectAppear;
    public Animator animator;

    public void OnPointerClick(PointerEventData eventData)
    {
        // Activate the object when clicked
        objectAppear.SetActive(true);
        animator.SetTrigger("Notification");
        objectDisapear.SetActive(false);


    }
}
