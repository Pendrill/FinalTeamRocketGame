using UnityEngine;
using System.Collections;

public class MoveBomb : MonoBehaviour {

	public bool isPlayerMovingBomb=true;
	public GameObject Explosion;
	private Animator animator;
	// Use this for initialization
	void Start () {
		//StartCoroutine (bombExplode ());
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		//We are checking if the bomb is still being moved by the DM
		if (isPlayerMovingBomb) {
			//Bomb follows the mouse cursor
			Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			cursorPositionInWorld.z = 0f;
			transform.position = cursorPositionInWorld;
			//player drops the bomb
			if (Input.GetMouseButtonUp (2)) {
				animator.SetTrigger ("BombCountdown");
				dropBomb ();
			}
		//player dropped the bomb
		} else {
			StartCoroutine (bombExplode());
			//This Debug.Log isn't exactly informative.
			//Debug.Log ("When does this appear");
		}
	}
	public void dropBomb(){
		//the bomb has been dropped, so it should no longer be affect by the mouse
		isPlayerMovingBomb = false;
	}
	public bool isBombDroped(){
		//we check if the bomb is still being manipulated by the Dm. If no return true
		if (isPlayerMovingBomb == false) {
			return true;
		} else {
			return false;
		}
	}
	
	IEnumerator bombExplode(){
		//Debug.Log ("test");
		yield return new WaitForSeconds (3);
		//Debug.Log ("test after 5 seconds");
		Instantiate (Explosion, transform.position, Explosion.transform.rotation);
		Destroy (this.gameObject);

	}
}
