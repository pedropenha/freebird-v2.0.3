using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupHandler : MonoBehaviour
{
    public static int qtdBirds = 0;
    public static int objective = 6;
    public GameObject textResetar;

    // Update is called once per frame
    void Update()
    {
        if (qtdBirds == objective)
        {
            textResetar.SetActive(true);
        }
    }
}
