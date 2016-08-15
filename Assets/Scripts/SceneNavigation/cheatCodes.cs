using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class cheatCodes : MonoBehaviour {
	

	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			PlayerPrefs.SetInt ("Player Health", 100);
			SceneManager.LoadScene (5);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			PlayerPrefs.SetInt ("Player Health", 100);
			SceneManager.LoadScene (3);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha3)) {
			PlayerPrefs.SetInt ("Player Health", 100);
			SceneManager.LoadScene (4);
		}
		else if (Input.GetKeyDown (KeyCode.Alpha4)) {
			PlayerPrefs.SetInt ("Player Health", 100);
			SceneManager.LoadScene (6);
		}
		else if (Input.GetKeyDown (KeyCode.T)) {
			PlayerPrefs.SetInt ("Player Health", 100);
			SceneManager.LoadScene (2);
		}
	}
}
