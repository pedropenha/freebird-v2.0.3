using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BackMenuControl : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    public MenuButton exit;
    public GameObject MainMenu;
    public GameObject ScenariosMenu;
    public GameObject ConfigMenu;
    public GameObject CreditsMenu;
    private bool active = false;
    public AudioClip audioClip;
    private AudioSource recursoAudio { get { return GetComponent<AudioSource>(); } }

    void Update()
    {
        if (Input.GetAxis("Cancel") == 1)
        {
            active = true;
        }
        else
        {
            if (active)
            {
                active = false;
                ativaMenu();
            }
        }
    }

    public void ativaMenu()
    {
        recursoAudio.clip = audioClip;
        recursoAudio.PlayOneShot(audioClip);
        
        if (MainMenu.activeSelf)
        {
            menuButtonController.index = exit.thisIndex;
        }
        else
        {
            ScenariosMenu.SetActive(false);
            ConfigMenu.SetActive(false);
            CreditsMenu.SetActive(false);
            MainMenu.SetActive(true);
        }
    }
}
