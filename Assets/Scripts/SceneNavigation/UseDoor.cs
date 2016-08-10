using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UseDoor : MonoBehaviour {
	public int whichSceneToLoad;
	void OnTriggerStay2D( Collider2D player){
		if (player.tag == "Player") {
			if (Input.GetKeyDown (KeyCode.W)) {
				SceneManager.LoadScene (whichSceneToLoad);
			}
		}
	}
}
