using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class trapBladeControls : MonoBehaviour {

	//stops swinging if current time is higher than this time
	private float stopSwingingAtThisTime = 0.0f;
	//speed adjustor
	public float swingSpeed = 1.0f;
	//public Button bladeButton;
	public BoxCollider2D bladeBoxCollider2D;

	void Start() {
		bladeBoxCollider2D = GetComponent<BoxCollider2D> ();
	}

	// Update is called once per frame
	void Update () {

		//if (Input.GetMouseButtonDown (0)) {
		//	toggle ();
		//}


		//if current time is less than the current time +2 seconds, activate
		if (Time.time < stopSwingingAtThisTime) {


			//bladeButton.interactable = false;
			bladeBoxCollider2D.enabled = true;
			transform.Rotate (transform.forward * Time.deltaTime * swingSpeed);


		


		} else {

			if (Input.GetMouseButtonDown (0)) {
				toggle ();
			}
			//bladeButton.interactable = true;
			bladeBoxCollider2D.enabled = false;
		}

	}


	public void toggle()
	{
		//Cooldown timer = current time + 2 seconds
		stopSwingingAtThisTime = Time.time + 2.0f;

	}

	//Deal damage to the player if they collide with the blade trap
	void OnTriggerEnter2D(Collider2D player){
		if (player.tag == "Player") {
			player.GetComponent<Player_Health> ().Hurt (15);
		}
	}
}
