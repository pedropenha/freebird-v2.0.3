using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
	[SerializeField] MenuButtonController menuButtonController;
	[SerializeField] Animator animator;
	[SerializeField] AnimatorFunctions animatorFunctions;
	[SerializeField] public int thisIndex;
    [SerializeField] MenuScreenControl MenuScreenControl;
    public GameObject Menu;
    //public AudioSource audioS;

    // Update is called once per frame
    void Update()
    {
		if(menuButtonController.index == thisIndex)
		{
            //audioS.GetComponent<AudioSource>().PlayOneShot();
			animator.SetBool ("selected", true);
            if (Input.GetAxis ("Submit") == 1){
				animator.SetBool ("pressed", true);
            }
            else if (animator.GetBool ("pressed")){
				animator.SetBool ("pressed", false);
				animatorFunctions.disableOnce = true;
                switch (tag)
                {
                    case "PlayBTN": SceneManager.LoadScene("Intro"); break;
                    case "ExitBTN": Application.Quit(); break;
                    default: MenuScreenControl.OpenMenu(Menu); break;
                }
            }
        }
        else{
			animator.SetBool ("selected", false);
		}
    }
}
