using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SpawnLazer : MonoBehaviour {

	public Transform spawner;
	public GameObject lazer;
	public GameObject lazerInWorld;
	public Button lazerButton;
	//GameObject player;
	//Transform playerT;
	// Use this for initialization
	/*void Start () {
		//player = GameObject.FindGameObjectWithTag ("Player");
		//playerT = player.GetComponent<Transform> ();
	}
*/
	// Update is called once per frame
	void Update () {
		//We need to check if there is already a lazer in the scene
		lazerInWorld = GameObject.FindGameObjectWithTag ("Lazer");
		if (lazerInWorld == null) {
			//If there is not then we can enable the player to create a new lazer by clicking the button
			lazerButton.interactable = true;
		} else {
			lazerButton.interactable = false;
		}
	}
	public void shootLazer(){
		//When the button is pressed, the lazer will be created slightly in from of the purple lazer spawner
		Instantiate (lazer, spawner.position , spawner.rotation);
	}
}
