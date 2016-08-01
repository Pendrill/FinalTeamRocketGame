using UnityEngine;
using System.Collections;

public class laserraycast : MonoBehaviour {
	public GameObject laserbeamobject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0f, 0f, -Input.GetAxis ("Horizontal") * Time.deltaTime * 90f);

		if (Input.GetKey (KeyCode.Space)) {
			laserbeamobject.SetActive (true);
			RaycastHit2D raycasthit = Physics2D.Raycast (transform.position, transform.up, 100f);
			if (raycasthit.collider != null){
				Destroy(raycasthit.collider.gameObject);

			}
				
		} else {
			laserbeamobject.SetActive (false);
		}
	
	}
}
