using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPot : MonoBehaviour {

	public float rotationSpeed = 50f;
	
	// Update is called once per frame
	void Update () {
		float rotationAngle = rotationSpeed * Time.deltaTime;
		transform.Rotate (Vector3.up * rotationAngle, Space.World);
		
	}
}
