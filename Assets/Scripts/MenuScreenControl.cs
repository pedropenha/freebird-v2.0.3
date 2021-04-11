using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScreenControl : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject ScenariosMenu;
    public GameObject ConfigMenu;
    public GameObject CreditsMenu;

    public void OpenMenu(GameObject menu)
    {
        MainMenu.SetActive(false);
        ScenariosMenu.SetActive(false);
        ConfigMenu.SetActive(false);
        CreditsMenu.SetActive(false);

        menu.SetActive(true);
    }
}
