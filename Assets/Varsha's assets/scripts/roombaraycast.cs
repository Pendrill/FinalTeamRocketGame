using UnityEngine;
using System.Collections;

public class roombaraycast : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		RaycastHit2D roombaHit = Physics2D.Raycast (transform.position, transform.up, 0.2f);
		if (roombaHit.collider != null) {
			//turn randomle 90 degrees
			float randomnumber = Random.Range(0f,1f);
			if (randomnumber > .5f) {
				transform.Rotate (0f, 0f, 90f);
			} else {
				transform.Rotate (0f, 0f, -90f);
			}

		} else {
			transform.position += transform.up * Time.deltaTime;
		}
	
	}
}
