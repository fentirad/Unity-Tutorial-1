﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () {
		Vector3 rotation = new Vector3 (15, 30, 45) * Time.deltaTime;
		transform.Rotate (rotation);
	}
}
