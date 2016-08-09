using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UseDoor : MonoBehaviour {
	public int whichSceneToLoad;
	private GameObject player;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	void OnTriggerStay2D( Collider2D player){
		if (player.tag == "Player") {
			if (Input.GetKeyDown (KeyCode.W)) {
				PlayerPrefs.SetInt ("Player Health", player.GetComponent<Player_Health> ().GetHealth());
				SceneManager.LoadScene (whichSceneToLoad);
			}
		}
	}
}
