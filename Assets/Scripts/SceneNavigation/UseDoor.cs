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
				//if the player touches the door, then they are teleported to the next dungeon.
				PlayerPrefs.SetInt ("Player Health", player.GetComponent<Player_Health> ().GetHealth());
				SceneManager.LoadScene (whichSceneToLoad);

		}
	}
}
