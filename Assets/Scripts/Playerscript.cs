using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour {

	public int playerhp = 100;
	public int armor = 0;
	// Update is called once per frame
	void Update () {

	
	}


	void OnCollisionEnter (Collision other){
		
		if (other.gameObject.tag == "level1enemy") {
			GameManager.instance.DecreaseLives ();
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "doortotutorial") {
			GameManager.instance.ToTutorial ();
		} else if (other.gameObject.tag == "doorto1") {
			GameManager.instance.ResetGame ();
		} else if (other.gameObject.tag == "doortosaved") {
			GameManager.instance.ToLastSaved ();
		} else if (other.gameObject.tag == "doortohome") {
			GameManager.instance.ToHome ();
		} else if (other.gameObject.tag == "doortogolf") {
			GameManager.instance.ToGolf ();
		} else if (other.gameObject.tag == "goal") {
			GameManager.instance.level2 ();
		} else if (other.gameObject.tag == "goal1") {
			GameManager.instance.level3 ();
		} else if (other.gameObject.tag == "goal2") {
			GameManager.instance.level4 ();
		} else if (other.gameObject.tag == "goal3") {
			GameManager.instance.level5 ();
		} else if (other.gameObject.tag == "cure") {
			GameManager.instance.winner ();
		} else if (other.gameObject.tag == "hppot") {
			GameManager.instance.addplayerhp ();
			Destroy (other.gameObject);
		}

	}
	/*
		if (other.CompareTag ("level2enemy")) {
			playerhp = playerhp - 10 + armor;
		}
		if (other.CompareTag ("level3enemy")) {
			playerhp = playerhp - 10 + armor;
		}

				*/
	
}
