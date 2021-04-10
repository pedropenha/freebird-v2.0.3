using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class vulcao : MonoBehaviour
{
    public GameObject magma;
    public GameObject fumaca;
    public GameObject eruptionSound;
    public GameObject magmaSound;
    private WaitForSeconds regenTick = new WaitForSeconds(0.1f);
    private Coroutine regen;

    void Start()
    {
        regen = StartCoroutine(RegenStamina());
    }

    private IEnumerator RegenStamina(){
        yield return new WaitForSeconds(10);

        fumaca.SetActive(true);

        yield return new WaitForSeconds(10);

        eruptionSound.SetActive(true);
        fumaca.SetActive(false);
        magma.SetActive(true);
        magmaSound.SetActive(true);
        // sound.SetActive(true);
    }

}