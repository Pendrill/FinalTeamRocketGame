using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (smokeDestroy ());
	}
	void OnTriggerEnter2D ( Collider2D exploder){
		//Use better debugging!
		//Debug.Log ("Hello");
		Debug.Log ("Explode.cs's on trigger firing")
		if (exploder.tag == "Player") {
			Destroy (exploder.gameObject);
		}

	}
	void OnTriggerStay2D ( Collider2D exploder){
		//Use better debugging!
		//Debug.Log ("Hello");
		Debug.Log ("Explode.cs's trigger stay firing")
		
		if (exploder.tag == "Player") {
			Destroy (exploder.gameObject);
		}

	}
	IEnumerator smokeDestroy(){
		yield return new WaitForSeconds (0.6f);
		Destroy (this.gameObject);

	}
}
