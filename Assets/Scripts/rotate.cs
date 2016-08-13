using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
	Rigidbody2D ourrigidbody;
	public float torque=4f;
	public float rotationtime = 1f;
	public float delaysecs=0;
	float delay=0;
	float counter=0;
	bool inrotation;
	// Use this for initialization
	void Start () {
	
		ourrigidbody = GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		// you should write comments about what this code does
		delay += Time.deltaTime;
		// you should write comments about what this code does
		if (Input.GetKey (KeyCode.LeftArrow) && ourrigidbody.angularVelocity == 0f && delay >= delaysecs) {
			inrotation = true;
			ourrigidbody.AddTorque (torque);
		} else if (Input.GetKey (KeyCode.RightArrow) && ourrigidbody.angularVelocity == 0f && delay >= delaysecs) {
			inrotation = true;
			ourrigidbody.AddTorque (-1f * torque);

		} else {
			ourrigidbody.angularVelocity = 0;
		}
		// you should write comments about what this code does
	/*	if (inrotation == true) {
			counter += Time.deltaTime;
			// you should write comments about what this code does
			if (counter >= rotationtime) {
				ourrigidbody.angularVelocity = 0;
				counter = 0;
				inrotation = false;
				delay = 0;
			}
		} */
			


	}
}
