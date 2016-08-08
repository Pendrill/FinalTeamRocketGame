using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class GoToFirstLevel : MonoBehaviour {

	public void StartLevelOne(){
		SceneManager.LoadScene (3);
	}
}
