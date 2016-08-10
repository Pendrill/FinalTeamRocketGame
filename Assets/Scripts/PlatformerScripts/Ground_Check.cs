using UnityEngine;
using System.Collections;

public class Ground_Check : MonoBehaviour {

	private PlayerMove player;
	private Player_Controller player2;
    private Improved_Player player3;
    public float raycastLine = 1f; // length of the raycast to check if grounded
    //public Transform groundChecker;

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<PlayerMove>();
		player2 = gameObject.GetComponentInParent<Player_Controller>();
        player3 = gameObject.GetComponentInParent<Improved_Player>();

    }
	
	void Update () {
		// HIGHLY RECOMMEND replacing your grounded check with a raycast instead of triggers
		// triggers aren't really the most stable for this
		// grounded checks are traditionally done with a very short downwards raycast below the player's feet
		RaycastHit2D groundHit = Physics2D.Raycast (transform.position,-transform.up,raycastLine);
        if (groundHit.collider != null)
        {
            player3.grounded = true;

        }
        else {
            player3.grounded = false;
        }

	}


	
}
