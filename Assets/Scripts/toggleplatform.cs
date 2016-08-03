using UnityEngine;
using System.Collections;

public class toggleplatform : MonoBehaviour {
	public GameObject ourplatform;
	public GameObject otherplatform;
	Collider2D othercollider;
	SpriteRenderer otherspriterenderer;
	SpriteRenderer ourspriterenderer;
	Collider2D ourcollider;
	public Sprite platformsprite;
	public bool invisiblefromstart=false;

	// Use this for initialization
	void Start () {
		ourspriterenderer = ourplatform.GetComponent<SpriteRenderer> ();
		otherspriterenderer = otherplatform.GetComponent<SpriteRenderer> ();
		ourcollider = ourplatform.GetComponent<Collider2D> ();
		othercollider = otherplatform.GetComponent<Collider2D> ();
		ourplatform.SetActive (false);
	
	
	
				
	
	}
	
	// Update is called once per frame
	void Update () {
		
		


	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			Debug.Log ("SWTITCHED");
			ourplatform.SetActive (true);
			ourspriterenderer.sprite = platformsprite;
			otherplatform.SetActive (false);
		}
	}
}
