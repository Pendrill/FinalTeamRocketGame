using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GoToTutorial : MonoBehaviour {

	public void tutorial(){
		SceneManager.LoadScene (2);
	}
}
