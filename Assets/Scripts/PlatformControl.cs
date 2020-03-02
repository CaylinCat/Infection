using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformControl : MonoBehaviour {

	//public Transform target;

	public Transform[] targets;

	public float speed = .5f;

	bool isMoving = false;

	int destinationIndex;

	// Use this for initialization
	void Start () {

		transform.position = targets [0].position;

		destinationIndex = 1;

	}

	// Update is called once per frame
	void Update () {

		if (isMoving) {
			SetMovement ();
		}

		GetInput();

	}

	void GetInput(){

		if (Input.GetButtonDown ("Fire1")) {
			isMoving = !isMoving;
		}

	}

	void SetMovement(){

		if (!isMoving) {
			return;
		}

		//distance to target
		float distance = Vector3.Distance(transform.position, targets[destinationIndex].position);

		//not at the target yet?
		if (distance > 0) {

			//how much we need to move
			float step = speed * Time.deltaTime;

			//move to target
			transform.position = Vector3.MoveTowards (transform.position, targets[destinationIndex].position, step);
		} else {
			if (destinationIndex < targets.Length - 1) {
				destinationIndex++;
			} else {
				destinationIndex = 0;
			}
			isMoving = true;
		}
	}
}