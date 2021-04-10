using System;
using System.Collections;
using UnityEngine;

public class Ally : MonoBehaviour
{
    public int id;
    public Transform target;
    
    [SerializeField] private float rotateSpeed = 0.8f;
    [SerializeField] private float followSpeed = 0.05f;
    [SerializeField] private float maxFollowSpeed = 12f;
    [SerializeField] private float rotationOffset = .01f;

    private BirdSide side;
    private Vector3 val = Vector3.zero;
    private GameObject player;
    private Transform transform;
    private Rigidbody rb;
    private Animator anim;
    private Vector3 targetRotation;

    float getAnimTime(string animationName) {
        RuntimeAnimatorController ac = anim.runtimeAnimatorController;    //Get Animator controller
        for (int i = 0; i < ac.animationClips.Length; i++)                 //For all animations
        {
            if (ac.animationClips[i].name == animationName)        //If it has the same name as your clip
                return ac.animationClips[i].length;
        }

        return 1;
    }


    private IEnumerator PlayJoiningGroup()
    {
        if (side == BirdSide.right)
        {
            anim.Play("left2right");
            float time = getAnimTime("left2right");
            yield return new WaitForSeconds(time);
        }
        else
        {
            anim.Play("right2left");
            float time = getAnimTime("right2left");
             yield return new WaitForSeconds(time);
        }
    }


    void Awake ()
    {
        side = PositionManager.invert ? BirdSide.left : BirdSide.right;
        player = GameObject.FindWithTag("Player");

        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        transform = GetComponent<Transform>();

        rotationOffset = 0.8f / GroupHandler.objective;
    }

    void OnEnable()
    {
        StartCoroutine("PlayJoiningGroup");
    }

    void Update()
    {
        FollowTarget();
    }

    private void FollowTarget()
    {
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref val, followSpeed, maxFollowSpeed);
        transform.rotation = Quaternion.Lerp(transform.rotation, player.transform.rotation, (rotateSpeed - rotationOffset * (id+1)) * Time.deltaTime);
    }
}

public enum BirdSide { left, right };
