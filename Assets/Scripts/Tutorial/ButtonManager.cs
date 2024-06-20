using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GameObject InformationMenu;
    public GameObject BG;
    public GameObject Button;

    public void ShowCards()
    {
        InformationMenu.SetActive(true);
    }

    public void HideCards()
    {
        InformationMenu.SetActive(false);
    }

    public void HideBg()
    {
        BG.SetActive(false);
        Button.SetActive(false);
    }
}