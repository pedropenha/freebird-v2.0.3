using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenarioMouseButton : MonoBehaviour
{
    [SerializeField] HorizontalMenuButtonController menuButtonController;
    [SerializeField] Animator animator;
    [SerializeField] ScenarioAnimatorFunctions animatorFunctions;
    [SerializeField] ScenarioMenuButton scenarioMenuButton;

    public void OnMouseOver()
    {
        animator.SetBool("selected", true);
        menuButtonController.index = scenarioMenuButton.thisIndex;
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
