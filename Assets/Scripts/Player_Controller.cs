using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {
    //Floats
    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 150;
    public float dashPower = 200;
	float coolDown = 2;

    //Booleans
    public bool grounded;
    public bool canDoubleJump;

    private Rigidbody2D playerRB;
    private Animator anim;

	// Use this for initialization
	void Start () {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();



    }
	
	// Update is called once per frame
	void Update () {
		coolDown += Time.deltaTime;
        anim.SetBool("Grounded",grounded);
        anim.SetFloat("Speed", Mathf.Abs( playerRB.velocity.x));
		// TODO add Coroutine to dash to stop collider
        if (Input.GetKeyDown(KeyCode.E))
        {
			if (coolDown >= 2) {
				//hor = 1;
				//playerRB.AddForce(Vector2.right * (dashPower * Time.deltaTime));
				playerRB.AddForce (new Vector2 (dashPower, 0));
				coolDown = 0;
			}

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
			if (coolDown >= 2) {
				//deactivate the boxCollider.
				//StartCoroutine (deactivateCollider ());
				//hor = -1;
				//playerRB.AddForce(Vector2.left * (dashPower * Time.deltaTime));
				//body.AddForce(new Vector2(dodgeForce, 0));
				playerRB.AddForce (new Vector2 (-dashPower, 0));
				coolDown = 0;
			}

        }

        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Q))
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }
		if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.E))
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKeyDown(KeyCode.Space)) {

            if (grounded)
            {

                playerRB.AddForce(Vector2.up * jumpPower);
                canDoubleJump = true;
            }
            else {
                if (canDoubleJump) {
                    canDoubleJump = false;
                    playerRB.velocity = new Vector2(playerRB.velocity.x, 0);
                    playerRB.AddForce(Vector2.up * jumpPower/ 1.5f);

                }

            }
        }



    }

	IEnumerator deactivateCollider(){
		yield return new WaitForSeconds (1);
		//activate the box collider again.

	}

    void FixedUpdate() {
        Vector3 easeVelocity = playerRB.velocity;
        easeVelocity.y = playerRB.velocity.y;
        easeVelocity.z = 0.0f;
        easeVelocity.x *= 0.75f;

        //float hor = Input.GetAxis("Horizontal");
        float hor = 0;

        if (Input.GetKey(KeyCode.D)) {
            hor = 1;

        }
        if (Input.GetKey(KeyCode.A))
        {
            hor = -1;

        }





        // moves the player
        playerRB.AddForce((Vector2.right * speed) * hor);
        //float movex = Input.GetAxis("Horizontal");
        //float movey = Input.GetAxis("Vertical");
       //playerRB.velocity = new Vector2(movex * maxSpeed,playerRB.velocity.y);

        // create fake friction on x axis
        //if (grounded) {
            playerRB.velocity = easeVelocity;
        //}


        // Limiting the player speed
        if (playerRB.velocity.x > maxSpeed)
        {

          //playerRB.velocity = new Vector2(maxSpeed, playerRB.velocity.y);

        }
        if (playerRB.velocity.x < -maxSpeed)
        {
            //playerRB.velocity = new Vector2(-maxSpeed, playerRB.velocity.y);
        }

    }
}
