using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainMenuMouseButton : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonController;
    [SerializeField] Animator animator;
    [SerializeField] AnimatorFunctions animatorFunctions;
    [SerializeField] MenuButton MenuButton;

    public void OnMouseOver()
    {
        menuButtonController.index = MenuButton.thisIndex;
    }

    public void OnMouseExit()
    {
        animator.SetBool("selected", false);
    }

    public void OnMouseUpAsButton()
    {
        animator.SetBool("pressed", true);
    }

}
