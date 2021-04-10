using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostPickUp : MonoBehaviour
{
    [SerializeField] private GameObject trigger;
    [SerializeField] private GameObject soundBoost;
    private Coroutine boost;

    // [SerializeField] private Transform player;

    // void Update()
    // {
    //     var newRotation = Quaternion.LookRotation(player.transform.position - transform.position).eulerAngles;
    //     newRotation.x = 0;
    //     transform.rotation = Quaternion.Euler(newRotation);
    // }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            soundBoost.GetComponent<AudioSource>().Play();
            boost = StartCoroutine(BoostPick());
            CircleStamina.instance.OasisStamina();
        }
    }
    private IEnumerator BoostPick(){
        
        flight.instance.Boost(10.0f);
        yield return new WaitForSeconds(1);
        Destroy(trigger);
    }
}
