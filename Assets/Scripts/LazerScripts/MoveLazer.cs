using UnityEngine;
using System.Collections;

public class MoveLazer : MonoBehaviour {

	private Rigidbody2D bulletRigidBody;
	public int moveSpeedBullet;
	// Use this for initialization
	void Start () {
		//attach the rigidbody to a variable.
		bulletRigidBody = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void FixedUpdate () {
		//add velocity so that the lazer will move along the red arrow. thus to the right or left...
		bulletRigidBody.velocity = (transform.right * moveSpeedBullet)*Time.deltaTime;  
	}

	//will deal damage and self destruct upon collision with the player.
	void OnCollisionEnter2D( Collision2D player){
		if (player.gameObject.tag == "Player") {
			player.gameObject.GetComponent<Player_Health> ().Hurt (10);
			Destroy (gameObject);
		}

	}
}
