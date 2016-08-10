using UnityEngine;
using System.Collections;

public class PlayerScale : MonoBehaviour {

	//This script can be used to reset the player character's size based on the size of the map.]
	public Vector3 newScale;
	// Use this for initialization
	void Start () {
		//changes the size of the player character to the set scale in the Inspector
		transform.localScale = newScale;
	}
	
	// Update is called once per frame
	void Update () {
		//Checks if the scale is set to the new one in the inspector. Changes it accordingly.
		if (transform.localScale != newScale) {
			transform.localScale = newScale;
		}
	
	}
}
