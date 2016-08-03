using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class trapBladeControls : MonoBehaviour {

	//stops swinging if current time is higher than this time
	private float stopSwingingAtThisTime = 0.0f;
	//speed adjustor
	public float swingSpeed = 1.0f;
	public Button bladeButton;




	// Update is called once per frame
	void Update () {

	


		//if current time is less than the current time +2 seconds, activate
		if (Time.time < stopSwingingAtThisTime) {


			bladeButton.interactable = false;
			transform.Rotate (transform.forward * Time.deltaTime * swingSpeed);


		


		}
		bladeButton.interactable = true;
		

	}


	public void toggle()
	{
		//Cooldown timer = current time + 2 seconds
		stopSwingingAtThisTime = Time.time + 2.0f;

	}
}
