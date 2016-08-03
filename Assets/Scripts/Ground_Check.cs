using UnityEngine;
using System.Collections;

public class Ground_Check : MonoBehaviour {

    private Player_Controller player;

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<Player_Controller>();
	
	}
	
	void Update () {
		// HIGHLY RECOMMEND replacing your grounded check with a raycast instead of triggers
		// triggers aren't really the most stable for this
		// grounded checks are traditionally done with a very short downwards raycast below the player's feet
	}

    void OnTriggerEnter2D(Collider2D coll) {
        player.grounded = true;

    }
    void OnTriggerStay2D(Collider2D coll)
    {
        player.grounded = true;

    }

    void OnTriggerExit2D(Collider2D coll) {
        player.grounded = false;

    }
	
	
}
