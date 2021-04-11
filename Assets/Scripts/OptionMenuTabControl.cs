using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenuTabControl : MonoBehaviour
{
    public GameObject AudioConfig;
    public GameObject VideoConfig;
    public GameObject Controls;

    public void OpenPanel(GameObject panel)
    {
        AudioConfig.SetActive(false);
        VideoConfig.SetActive(false);
        Controls.SetActive(false);

        panel.SetActive(true);
    }
}
