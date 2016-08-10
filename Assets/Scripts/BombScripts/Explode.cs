using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine (smokeDestroy ());
	}
	//Deal damage to the player if they collide with the Bomb's explosion
	void OnTriggerEnter2D(Collider2D player){
		if (player.tag == "Player") {
			player.GetComponent<Player_Health> ().Hurt (30);
		}
	}
	//Deal damage to the player if they collide with the Bomb's explosion
	/*void OnTriggerStay2D(Collider2D player){
		if (player.tag == "Player") {
			player.GetComponent<Player_Health> ().Hurt (30);
		}
	}*/
	//Deal damage to the player if they collide with the Bomb's explosion
	void OnTriggerExit2D(Collider2D player){
		if (player.tag == "Player") {
			player.GetComponent<Player_Health> ().Hurt (30);
		}
	}
	IEnumerator smokeDestroy(){
		yield return new WaitForSeconds (0.6f);
		Destroy (this.gameObject);

	}
}
