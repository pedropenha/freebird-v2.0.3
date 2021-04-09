using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Oasis : MonoBehaviour
{
	public GameObject trigger;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CircleStamina.instance.OasisStamina();
        }
    }
	
}
