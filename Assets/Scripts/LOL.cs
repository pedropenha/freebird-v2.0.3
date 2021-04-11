using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOL : MonoBehaviour
{
    public AudioClip audioClip;
    private int clicks = 0;
    private AudioSource source { get { return GetComponent<AudioSource>(); } }

    void Start()
    {
        source.clip = audioClip;
        source.playOnAwake = false;
    }

    public void LolFunction()
    {

        if(clicks < 6)
        {
            Debug.Log("U found me :b");
            clicks++;
        }
        else
        {
            Debug.Log("LOOL");
            source.PlayOneShot(audioClip);
            clicks = 0;
        }
    }
}
