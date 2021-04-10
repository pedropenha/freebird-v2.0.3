using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionManager : MonoBehaviour
{
    public Vector3 offset;
    public static bool invert;

    [SerializeField] private Transform initialPosition;
    [SerializeField] private GameObject follower;
    [SerializeField] private GameObject player;

    private Vector3 currentPosition;

    void OnEnable()
    {
        HandleEffect.BirdCall += CreateFollower;
    }

    void OnDisable()
    {
        HandleEffect.BirdCall -= CreateFollower;
    }

    void Awake()
    {
        currentPosition = initialPosition.localPosition;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            CreateFollower();
        }
    }

    public void CreateFollower()
    {
        if(invert)
        {
            InvertPosition();
            currentPosition += offset; // Somo o offset para avançar a "linha" das posições dos passáros
            return;
        }

        GameObject target = createTarget(currentPosition); // Instancia o target

        GameObject newFollower = createObject(currentPosition); // Instancia um passaro
        newFollower.GetComponent<Ally>().target = target.transform;
        newFollower.GetComponent<Ally>().id = GroupHandler.qtdBirds;
       
        GroupHandler.qtdBirds++;

        invert = !invert;
    }

    public void InvertPosition()
    {
        Vector3 pos = currentPosition;
        pos.x *= -1;

        GameObject target = createTarget(pos); // Instancia o target

        GameObject newFollower = createObject(pos);
        newFollower.GetComponent<Ally>().target = target.transform;
        newFollower.GetComponent<Ally>().id = GroupHandler.qtdBirds;

        GroupHandler.qtdBirds++;

        invert = !invert;
    }

    public GameObject createObject(Vector3 currentPosition)
    {
        GameObject newFollower = Instantiate(follower, transform.TransformPoint(currentPosition), player.transform.rotation);
        return newFollower;
    }

    public GameObject createTarget(Vector3 currentPosition)
    {
        GameObject target = new GameObject();
        target.transform.position = transform.TransformPoint(currentPosition);
        target.transform.SetParent(gameObject.transform);
        return target;
    }
}
