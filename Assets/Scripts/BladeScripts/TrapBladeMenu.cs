using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrapBladeMenu : MonoBehaviour {

	//stops swinging if current time is higher than this time
	private float stopSwingingAtThisTime = 0.0f;
	//speed adjustor
	public float swingSpeed = 360.0f;
	//public Button bladeButton;
	//public BoxCollider2D bladeBoxCollider2D;

	void Start() {
		
	}

	// Update is called once per frame
	void Update () {


			//bladeBoxCollider2D.enabled = true;
			transform.Rotate (transform.forward * Time.deltaTime * swingSpeed);






	}
}
