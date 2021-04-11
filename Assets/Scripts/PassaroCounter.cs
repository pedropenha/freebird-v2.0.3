using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PassaroCounter : MonoBehaviour
{
    public static int rescuedValue = 0;
    public TextMeshProUGUI birdRescued;

    // Start is called before the first frame update
    void Start()
    {
        birdRescued = GetComponent<TextMeshProUGUI> ();
    }

    // Update is called once per frame
    void Update()
    {
        birdRescued.text = $"Resgatar os pássaros:  ({GroupHandler.qtdBirds} / {GroupHandler.objective})";
    }

    //teste
    public void AumentaPassaro()
    {
        rescuedValue = rescuedValue + 1;
    }

    public void DiminuiPassaro()
    {
        rescuedValue = rescuedValue - 1;
    }
}
