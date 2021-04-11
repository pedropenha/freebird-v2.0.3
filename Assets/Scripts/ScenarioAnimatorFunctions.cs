using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioAnimatorFunctions : MonoBehaviour
{
	[SerializeField] HorizontalMenuButtonController menuButtonController;
	public bool disableOnce;

	void PlaySound(AudioClip whichSound){
		if(!disableOnce){
			menuButtonController.audioSource.PlayOneShot (whichSound);
		}else{
			disableOnce = false;
		}
	}
}	
