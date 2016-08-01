using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {
    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 150;
    public bool grounded;

    private Rigidbody2D playerRB;
    private Animator anim;

	// Use this for initialization
	void Start () {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();



    }
	
	// Update is called once per frame
	void Update () {
        anim.SetBool("Grounded",grounded);
        anim.SetFloat("Speed", Mathf.Abs( playerRB.velocity.x));

        if (Input.GetAxis("Horizontal") < -0.1)
        {
            transform.localScale = new Vector3(-1, 1, 1);

        }
        if (Input.GetAxis("Horizontal") > 0.1)
        {
            transform.localScale = new Vector3(1, 1, 1);

        }
        if (Input.GetKeyDown(KeyCode.Space) && grounded) {

            playerRB.AddForce(Vector2.up * jumpPower);
        }



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

        // create fake friction on x axis
        if (grounded) {
            playerRB.velocity = easeVelocity;
        }


        // Limiting the player speed
        if (playerRB.velocity.x > maxSpeed)
        {

            playerRB.velocity = new Vector2(maxSpeed, playerRB.velocity.y);

        }
        if (playerRB.velocity.x < -maxSpeed)
        {
            playerRB.velocity = new Vector2(-maxSpeed, playerRB.velocity.y);
        }

    }
}
