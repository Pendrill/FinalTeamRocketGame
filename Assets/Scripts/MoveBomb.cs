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
		//What is this doing?
		if (isPlayerMovingBomb) {
			Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			cursorPositionInWorld.z = 0f;
			transform.position = cursorPositionInWorld;
			if (Input.GetMouseButtonUp (0)) {
				animator.SetTrigger ("BombCountdown");
				dropBomb ();
			}
		//Good place for a comment
		} else {
			StartCoroutine (bombExplode());
			//This Debug.Log isn't exactly informative.
			Debug.Log ("When does this appear");
		}
	}
	public void dropBomb(){
		//Comment this function!
		isPlayerMovingBomb = false;
	}
	public bool isBombDroped(){
		//This one too.
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
