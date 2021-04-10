using System;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class HandleEffect : MonoBehaviour
{
    public GameObject radio;
    public GameObject nature;
    public GameObject trigger;
    public GameObject soundDestroy;
    public GameObject groupManager;

    public static Action BirdCall;
    
    public PostProcessVolume volume;
    private ColorGrading colorGradingLayer = null;

    void Awake()
    {
        volume.profile.TryGetSettings(out colorGradingLayer);
    }

    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            colorGradingLayer.saturation.value += 100 / GroupHandler.objective;
            soundDestroy.GetComponent<AudioSource>().Play();
            radio.GetComponent<AudioSource>().volume += (0.05F * GroupHandler.qtdBirds);
            nature.GetComponent<AudioSource>().volume += (0.1f * GroupHandler.qtdBirds);
            GameObject.Destroy(trigger);

            BirdCall?.Invoke();
        }
    }
}
