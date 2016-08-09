using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timer : MonoBehaviour {
	public Text timertext;
	float timerr=0f;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		timerr += Time.deltaTime;
		timertext.text = timerr.ToString();
	
	}
}
