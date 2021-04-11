using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class SettingsMenu : MonoBehaviour
{
    public TMP_Dropdown resolutionList;
    Resolution[] resolutions;

    public AudioMixer audioMixer;

    void Start()
    {
        resolutions = Screen.resolutions;
        resolutionList.ClearOptions();

        int currentResolutionIndex = 0;
        List<string> options = new List<string>();
        for(int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionList.AddOptions(options);
        resolutionList.value = currentResolutionIndex;
        resolutionList.RefreshShownValue();
    }

    public void SetMasterVolume (float volume)
    {
        audioMixer.SetFloat("MasterVlm", volume);
    }

    public void SetMusicVolume (float volume)
    {
        audioMixer.SetFloat("MusicVlm", volume);
    }

    public void SetSoundsVolume (float volume)
    {
        audioMixer.SetFloat("SoundVlm", volume);
    }

    public void Mutar (bool toogleMudo)
    {
        if (toogleMudo)
        {
            AudioListener.volume = 0;
        }
        else
        {
            AudioListener.volume = 1;
        }
        
    }

    public void SetQuality (int qualidade)
    {
        QualitySettings.SetQualityLevel(qualidade);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution (int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

}
