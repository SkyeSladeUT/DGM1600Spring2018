using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	Rigidbody RB;
	public float jumpSpeed;
	public float sideSpeed;
	public int PlayerNum;

	void Start () {
		RB = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Jump();
		Move();
	}
	void Jump() {
		if(Input.GetButtonDown("Vertical" + PlayerNum)) {
			if (Input.GetAxisRaw("Vertical" + PlayerNum) > 0) {
				RB.velocity = Vector3.up * jumpSpeed;
			}
		}
	}

	void Move() {
		if(Input.GetButton("Horizontal" + PlayerNum)) {
			if (Input.GetAxisRaw("Horizontal" + PlayerNum) > 0) {
				RB.velocity = Vector3.right * sideSpeed;
			}
			else {
				RB.velocity = Vector3.left * sideSpeed;
			}
		}
	}
}
