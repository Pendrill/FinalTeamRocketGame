using UnityEngine;
using System.Collections;

public class DestroyLazer : MonoBehaviour {


	void OnCollisionEnter2D( Collision2D lazer){
		if (lazer.gameObject.tag == "Lazer") {
			Destroy (lazer.gameObject);
		}

	}
}
