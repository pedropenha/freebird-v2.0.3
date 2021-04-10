using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPickUp : MonoBehaviour
{
    [SerializeField] private GameObject trigger;
    [SerializeField] private Transform player;

    void Update()
    {
        var newRotation = Quaternion.LookRotation(player.transform.position - transform.position).eulerAngles;
        newRotation.x = 0;
        transform.rotation = Quaternion.Euler(newRotation);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            CircleStamina.instance.OasisStamina();
            Destroy(trigger);
        }
    }
}
