using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class WallProps : MonoBehaviour {

	public bool _isEnabled = false;
	// Use this for initialization
	
	void Start () {
		if (!_isEnabled){
			gameObject.GetComponent<Renderer>().enabled = false;
			gameObject.GetComponent<BoxCollider>().enabled = false;
		}
		else{
			gameObject.GetComponent<Renderer>().enabled = true;
			gameObject.GetComponent<BoxCollider>().enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
