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
		Debug.Log ("Hello");
		if (exploder.tag == "Player") {
			Destroy (exploder.gameObject);
		}

	}
	void OnTriggerStay2D ( Collider2D exploder){
		Debug.Log ("Hello");
		if (exploder.tag == "Player") {
			Destroy (exploder.gameObject);
		}

	}
	IEnumerator smokeDestroy(){
		yield return new WaitForSeconds (0.6f);
		Destroy (this.gameObject);

	}
}
