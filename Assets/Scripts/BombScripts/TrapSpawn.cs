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
		if (nextBomb&&BombInWorld==null) {
			if (Input.GetMouseButtonDown (2)) {
				createTrap (BombPrefab);
			}
		}
	}
	public void createTrap (GameObject Bomb){
		if (nextBomb && BombInWorld == null) {
			//bombButton.interactable == true;
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
