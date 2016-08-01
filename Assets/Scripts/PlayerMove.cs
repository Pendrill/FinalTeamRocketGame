using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float moveSpeed = 5f;
	Vector2 moveVector = new Vector2 (0f,0f);
	Rigidbody2D playerRigidBody;
	// Use this for initialization
	void Start () {
		playerRigidBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");
		moveVector = new Vector2 (horizontal, vertical);
		if (moveVector.magnitude > 1f) {
			moveVector = moveVector.normalized;
		}
	}
	void FixedUpdate(){
		playerRigidBody.velocity = moveVector * moveSpeed;
	}
}
