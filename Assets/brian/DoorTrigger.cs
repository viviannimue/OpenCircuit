﻿using UnityEngine;
using System.Collections;

[AddComponentMenu("Scripts/Doors/Door Trigger")]
public class DoorTrigger : MonoBehaviour {

	private DoorControl control = null;

	void Awake() {
		control = GetComponentInChildren<DoorControl> ();
	}

	void OnTriggerEnter(Collider collision) {
		//print (collision.gameObject.GetType ());
		RobotController controller = collision.attachedRigidbody.gameObject.GetComponent<RobotController> ();
		if (controller != null) {
			control.toggle ();
		}
	}
}
