using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class flight : MonoBehaviour
{

    public float speed;
    public float rotationSpeed;
    public float speedUp;
    public float speedBoost;

    public GameObject songBoost;
    public int qtdBirds = 0;
    public GameObject resetar;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Input.GetAxis("Vertical") * speedUp * Time.deltaTime, 0.0f, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);

        float boost = Input.GetAxis("Boost") * speedBoost;

        boost *= Time.deltaTime;

        if(boost > 0 && CircleStamina.instance.getStamina() > 0.01f)
        //if(boost > 0)
        {
            songBoost.GetComponent<AudioSource>().volume = 1.0F;
            transform.position += transform.forward * Time.deltaTime * speed * boost;
            CircleStamina.instance.UseStamina(0.01f);
            // CircleStamina.instance.OasisStamina();
        }
        else
        {
            songBoost.GetComponent<AudioSource>().volume = 0.0F;
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if(qtdBirds == 4)
        {
            resetar.SetActive(true); 
        }
    }
}