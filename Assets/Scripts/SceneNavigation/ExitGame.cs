using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//The game will close if escape is pressed
		if (Input.GetKey (KeyCode.Escape)) {
			Application.Quit ();
		}
	}
}
