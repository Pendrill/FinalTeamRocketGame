using UnityEngine;
using System.Collections;

public class DestroyLazer : MonoBehaviour {


	void OnCollisionEnter2D( Collision2D lazer){
		//if the laser hits a wall then it gets destroyed
		if (lazer.gameObject.tag == "Lazer") {
			Destroy (lazer.gameObject);
		}

	}
}
