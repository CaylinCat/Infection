using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class golfcode : MonoBehaviour {

	Vector3 originalPos;
	public static bool reload = false;
	void Start() {
		originalPos = gameObject.transform.position;
	}

	void OnCollisionEnter (Collision other) {
		if (other.gameObject.tag == "hole") {
			gameObject.transform.position = originalPos;
		}	
	}

	void Update() {
		if (reload) {
			gameObject.transform.position = originalPos;
			reload = false;
		}
	} 

}
