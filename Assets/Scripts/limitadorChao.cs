using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitadorChao : MonoBehaviour
{
    public GameObject bird;
    private float x;
    private float y;
    private float z;

    void OnTriggerEnter(Collider other)
    {
        x = bird.transform.position.x;
        y = bird.transform.position.y;
        z = bird.transform.position.z;

        Vector3 aux = new Vector3(x, y + 100, z);

        bird.transform.position = aux;
    }
}
