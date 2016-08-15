using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TrapSpawn : MonoBehaviour {
	bool nextBomb=true;
	//public Button bombButton;
	public GameObject BombInWorld;
	public GameObject BombPrefab;
	void Update(){
		BombInWorld = GameObject.FindGameObjectWithTag ("Bomber");
		//checks to see how many bombs there are in the scene, to see if the DM can create an other
		if (nextBomb&&BombInWorld==null) {
			if (Input.GetMouseButtonDown (2)) {
				createTrap (BombPrefab);
			}
		}
	}
	public void createTrap (GameObject Bomb){
		if (nextBomb && BombInWorld == null) {
			//bombButton.interactable == true;
			//a new bomb is created at the mouse's position
			Instantiate (Bomb, Camera.main.ScreenToWorldPoint (Input.mousePosition), Bomb.transform.rotation);
			//bombButton.interactable = false;
			nextBomb = false;
			StartCoroutine (bombReady ());
		} else {
			//bombButton.interactable = false;
		}
	}
	IEnumerator bombReady(){
		yield return new WaitForSeconds (3);
		nextBomb = true;
		//bombButton.interactable = true;
	}

}
