using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyfollow : MonoBehaviour {

	public Transform target;
	public Transform myTransform;
	public int health = 10;
	//public int rotationSpeed = 5;


	void Start() {

	/*	if (gameObject.tag == "level1enemy") {
			health = 10;
		} else if (gameObject.tag == "level2enemy") {
			health = 20;
		} else if (gameObject.tag == "level3enemy") {
			health = 50;
		} else {
			health = 5;
		}  */
	
	}


	// Update is called once per frame
	void Update () {

		transform.LookAt (target);
		//transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position), rotationSpeed * Time.deltaTime);
		transform.Translate (Vector3.forward * 1 * Time.deltaTime);

			
		if (health <= 0) {
			GameManager.instance.DeathSound ();
			Destroy (gameObject);
		}


	}



	void OnCollisionEnter (Collision other) {
		if(other.gameObject.tag == "level1weapon") {
			health = health - 1;
		} else if(other.gameObject.tag == "level2weapon") {
			health = health - 2;
		} else if(other.gameObject.tag == "level3weapon") {
			health = health - 5;
		}
	
    	

	}
}


//for target drag the OVR player controller & for my transform drag the enemy this script is placed on