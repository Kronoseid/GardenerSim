﻿using UnityEngine;
using System.Collections;

public class planterMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 forward = transform.TransformDirection (Vector3.forward);
		Debug.DrawLine(transform.position, transform.position+forward*3f, Color.red);
		rigidbody.AddForce(transform.forward * 750f * Time.deltaTime);

		if (Physics.Raycast(transform.position, transform.forward, 3f)){
			transform.eulerAngles = new Vector3(0f, Random.Range(0f,359f), 0f);
		}
	}
}
