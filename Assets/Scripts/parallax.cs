using UnityEngine;
using System.Collections;

public class parallax : MonoBehaviour {

	public GameObject maincam;
	public float parallaxamt = .8f;
	Camera cam;
	// Use this for initialization
	void Start () {
		cam = maincam.GetComponent<Camera> ();


	}

	// Update is called once per frame
	void Update () {
		transform.position = parallaxamt * cam.ScreenToWorldPoint (Vector3.zero);


	}
}