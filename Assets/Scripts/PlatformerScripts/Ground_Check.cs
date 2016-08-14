using UnityEngine;
using System.Collections;

public class Ground_Check : MonoBehaviour {
	
    private Improved_Player player;
    public float raycastLine = 1f; // length of the raycast to check if grounded
    //public Transform groundChecker;

	// Use this for initialization
	void Start () {
        

        player = gameObject.GetComponentInParent<Improved_Player>();

    }
	
	void Update () {
		// HIGHLY RECOMMEND replacing your grounded check with a raycast instead of triggers
		// triggers aren't really the most stable for this
		// grounded checks are traditionally done with a very short downwards raycast below the player's feet


		// For some reason always true could not fix so going back to triggers
//		RaycastHit2D groundHit = Physics2D.Raycast (transform.position,-transform.up,raycastLine);
//        if (groundHit.collider != null)
//        {
//            player.grounded = true;
//
//        }
//        else {
//            player.grounded = false;
//        }
	
	}
	void OnTriggerStay2D(Collider2D col) {
		player.grounded = true;

	}
	void OnTriggerExit2D(Collider2D col) {
		player.grounded = false;

	}



	
}
