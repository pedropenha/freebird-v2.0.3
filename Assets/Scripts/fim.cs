using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fim : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && GroupHandler.objective == GroupHandler.qtdBirds)
        {
            if(SceneManager.GetActiveScene().name == "map1"){
                SceneManager.LoadScene("map2");
            }else{
                SceneManager.LoadScene("creditosNew");
            }
        }
     }
}
