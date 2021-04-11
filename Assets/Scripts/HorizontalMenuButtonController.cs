using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMenuButtonController : MonoBehaviour {

	// Use this for initialization
	public int index;
	[SerializeField] bool keyDown;
	[SerializeField] int maxIndex;
	public AudioSource audioSource;

	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis ("Horizontal") != 0){
            if (!keyDown){
				if (Input.GetAxis ("Horizontal") < 0) {
					if(index < maxIndex){
                        index++;
                        Debug.Log(index);
                    }
                    else{
                        index = 0;
                        Debug.Log(index);
                    }
				} else if(Input.GetAxis ("Horizontal") > 0){
                    if (index > 0){
						index --;
                        Debug.Log(index);
                    }
                    else{
						index = maxIndex;
                        Debug.Log(index);
                    }
				}
				keyDown = true;
			}
		}else{
			keyDown = false;
		}
	}

}
