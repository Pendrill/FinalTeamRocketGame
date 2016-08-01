using UnityEngine;
using System.Collections;

public class Ground_Check : MonoBehaviour {

    private Player_Controller player;

	// Use this for initialization
	void Start () {
        player = gameObject.GetComponentInParent<Player_Controller>();
	
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
