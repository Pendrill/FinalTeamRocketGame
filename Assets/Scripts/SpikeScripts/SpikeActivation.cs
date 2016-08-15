using UnityEngine;
using System.Collections;

public class SpikeActivation : MonoBehaviour {

	public GameObject spike;
	public GameObject Activator;

	// Use this for initialization
	void Start () {

	}

	void Update () {

		RaycastHit2D raycastHit = Physics2D.Raycast (transform.position, transform.up, 5f);
	    
		if (raycastHit.collider != null) {

			spike.SetActive (true);
		}else{
			spike.SetActive (false);
		}

	}
		    

	void OntriggerEnter2D ( Collider2D Activator ) {

		if (Activator.GetComponent<Rigidbody> () != null) {

			Destroy (Activator.gameObject);
				
		} 
	}
}
