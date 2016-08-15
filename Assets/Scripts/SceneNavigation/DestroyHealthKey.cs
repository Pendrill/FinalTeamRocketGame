	using UnityEngine;
using System.Collections;

public class DestroyHealthKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//we reset the player's health every game
		PlayerPrefs.SetInt ("Player Health", 100);
	}
	

}
