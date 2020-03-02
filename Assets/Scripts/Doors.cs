using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour {

	private Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onCollisionEnter (Collision other) {
		if (other.gameObject.tag == "level1weapon") {
			anim.SetBool ("open", true);
		}
	}

	void onCollisionExit (Collision other) {
		anim.SetBool ("open", false);
	}
		
}

