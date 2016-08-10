using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	private Rigidbody2D playerRB;
	private SpriteRenderer playerSR;
	private Animator anim;

	//Booleans
	public bool grounded;
	public bool canDoubleJump;
	public bool rolling;

	//Floats
	//public float maxSpeed = 100;
	//public float speed = 5f;
	public float moveSpeed = 5f;
	public float jumpPower = 5;
	public float dashPower = 200;
	float coolDown = 2;


	Vector2 moveVector = new Vector2 (0f,0f);

	// Use this for initialization
	void Start () {
		playerRB = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();
		playerSR = gameObject.GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {
		//float horizontal = Input.GetAxis ("Horizontal");
		//float vertical = Input.GetAxis ("Vertical");
		float horizontal = 0;

		if (Input.GetKey(KeyCode.D)) {
			horizontal = 1;

		}
		if (Input.GetKey(KeyCode.A))
		{
			horizontal = -1;

		}



		moveVector = new Vector2 (horizontal,0);
		if (moveVector.magnitude > 1f) {
			moveVector = moveVector.normalized;
		}

		coolDown += Time.deltaTime;
		anim.SetBool("Grounded",grounded);
		anim.SetBool ("Rolling",rolling);
		anim.SetFloat("Speed", Mathf.Abs( playerRB.velocity.x));

		if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Q))
		{
			//transform.localScale = new Vector3(-1, 1, 1);
			if (playerSR.flipX == false) {
				playerSR.flipX = true;
			}

		}
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.E))
		{
			if (playerSR.flipX == true) {
				playerSR.flipX = false;
			}
			//transform.localScale = new Vector3(1, 1, 1);
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			if (coolDown >= 2) {
				//hor = 1;
				//playerRB.AddForce(Vector2.right * (dashPower * Time.deltaTime));
				playerRB.AddForce (new Vector2 (dashPower, 0));
				coolDown = 0;
				//rolling = true;
			} 

		}
		if(Input.GetKeyDown(KeyCode.Q))
		{
			if (coolDown >= 2) {
				//deactivate the boxCollider.
				//StartCoroutine (deactivateCollider ());
				//hor = -1;
				//playerRB.AddForce(Vector2.left * (dashPower * Time.deltaTime));
				//body.AddForce(new Vector2(dodgeForce, 0));
				playerRB.AddForce (new Vector2 (-dashPower, 0));
				coolDown = 0;
				//rolling = true;
			} 

		}
		if (Input.GetKeyDown(KeyCode.Space)) {

			if (grounded)
			{

				//playerRB.AddForce(Vector2.up * jumpPower);
				playerRB.velocity = new Vector2(playerRB.velocity.x,jumpPower);
				//canDoubleJump = true;
			}
//			else {
//				if (canDoubleJump) {
//					canDoubleJump = false;
//					playerRB.velocity = new Vector2(playerRB.velocity.x, 0);
//					playerRB.AddForce(Vector2.up * jumpPower);
//
//				}
//
//			}
		}

	}
	void FixedUpdate(){
		playerRB.velocity = moveVector * moveSpeed;
	}
}
