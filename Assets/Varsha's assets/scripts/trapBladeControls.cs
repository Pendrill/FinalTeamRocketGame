using UnityEngine;
using System.Collections;

public class prototypeBladeTrap : MonoBehaviour {



	// Update is called once per frame
	void Update () {


		if (Input.GetKey(KeyCode.Keypad1)) {
			transform.Rotate (transform.forward);
		}

		if (Input.GetKey (KeyCode.Keypad3)) {
			transform.Rotate (-transform.forward); 
		}

	}
}
