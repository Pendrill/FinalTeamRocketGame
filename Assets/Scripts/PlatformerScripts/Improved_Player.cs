using UnityEngine;
using System.Collections;

public class Improved_Player : MonoBehaviour {
    //Floats
    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 275f;
    public float dashPower = 200;
    float coolDown = 2;

    

    //Booleans
    public bool grounded;
    public bool canDoubleJump;
    //References
    private Rigidbody2D playerRB;
    private Animator anim;
    private SpriteRenderer playerSR;

    // Use this for initialization
    void Start () {
        

        playerRB = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        playerSR = gameObject.GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        coolDown += Time.deltaTime;
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(playerRB.velocity.x));

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (coolDown >= 2)
            {
                //hor = 1;
                //playerRB.AddForce(Vector2.right * (dashPower * Time.deltaTime));
                playerRB.AddForce(new Vector2(dashPower, 0));
                coolDown = 0;
                //rolling = true;
            }

        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (coolDown >= 2)
            {
                //deactivate the boxCollider.
                //StartCoroutine (deactivateCollider ());
                //hor = -1;
                //playerRB.AddForce(Vector2.left * (dashPower * Time.deltaTime));
                //body.AddForce(new Vector2(dodgeForce, 0));
                playerRB.AddForce(new Vector2(-dashPower, 0));
                coolDown = 0;
                //rolling = true;
            }

        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.Q))
        {
            //transform.localScale = new Vector3(-1, 1, 1);
            if (playerSR.flipX == false)
            {
                playerSR.flipX = true;
            }

        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.E))
        {
            if (playerSR.flipX == true)
            {
                playerSR.flipX = false;
            }
            //transform.localScale = new Vector3(1, 1, 1);

        }


        if (Input.GetButtonDown("Jump"))
        {
            if (grounded)
            {
                playerRB.AddForce(Vector2.up * jumpPower);
                canDoubleJump = true;
                //GetComponent<AudioSource> ().Play ();

            }
            else {
                if (canDoubleJump)
                {
                    canDoubleJump = false;
                    playerRB.velocity = new Vector2(playerRB.velocity.x, 0);
					playerRB.AddForce(Vector2.up * jumpPower / 1.5f);
                    //GetComponent<AudioSource> ().Play ();
                }

            }

        }

    }
    void FixedUpdate()
    {
        Vector3 slowVel = playerRB.velocity;
        slowVel.y = playerRB.velocity.y;
        slowVel.z = 0.0f;
        slowVel.x *= 0.8f;

        //float horizontal = Input.GetAxis("Horizontal");
        float hor = 0;

        if (Input.GetKey(KeyCode.D))
        {
            hor = 1;

        }
        if (Input.GetKey(KeyCode.A))
        {
            hor = -1;

        }
        // Create friction
        if (grounded)
        {
            playerRB.velocity = slowVel;

        }
        // move player
        playerRB.AddForce((Vector2.right * speed) * hor);

        //Limit speed
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
