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
    public GameObject text;
    public static flight instance;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Input.GetAxis("Vertical") * speedUp * Time.deltaTime, 0.0f, -Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime);

        float boost = Input.GetAxis("Boost") * speedBoost;

        boost *= Time.deltaTime;

        if(boost > 0 && CircleStamina.instance.getStamina() > 0.01f)
        {
            this.Boost(boost);
            songBoost.GetComponent<AudioSource>().volume = 1.0F;
            CircleStamina.instance.UseStamina(0.01f);
        }
        else
        {
            songBoost.GetComponent<AudioSource>().volume = 0.0F;
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if(GroupHandler.objective == GroupHandler.qtdBirds){
            text.SetActive(true);
        }else{
            text.SetActive(false);
        }
    }

    public void Boost(float boost)
    {
        transform.position += transform.forward * Time.deltaTime * speed * boost;
    }
}