using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioMenuButton : MonoBehaviour
{
	[SerializeField] HorizontalMenuButtonController menuButtonController;
	[SerializeField] Animator animator;
	[SerializeField] ScenarioAnimatorFunctions animatorFunctions;
	[SerializeField] public int thisIndex;
    public string[] mapas = { "map1", "map2" };
    // Update is called once per frame
    void Update()
    {
		if(menuButtonController.index == thisIndex)
		{
			animator.SetBool ("selected", true);
			if(Input.GetAxis ("Submit") == 1){
				animator.SetBool ("pressed", true);
			}else if (animator.GetBool ("pressed")){
				animator.SetBool ("pressed", false);
				animatorFunctions.disableOnce = true;
                SceneManager.LoadScene(mapas[thisIndex]);
            }
        }
        else{
			animator.SetBool ("selected", false);
		}
    }
}
