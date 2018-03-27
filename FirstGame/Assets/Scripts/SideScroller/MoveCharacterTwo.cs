using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterTwo : MonoBehaviour {

	public Character myCharacter;
    private CharacterController controller;

	private void Start() {
		controller = GetComponent<CharacterController>();
	}

    void Update() {
        if (controller.isGrounded) {

			myCharacter.moveDirection.x = Input.GetAxis("Horizontal");
			myCharacter.moveDirection.z = Input.GetAxis("Vertical");
			myCharacter.moveDirection.y = 0;

            myCharacter.moveDirection = transform.TransformDirection(myCharacter.moveDirection);
            myCharacter.moveDirection *= myCharacter.speed;
            if (Input.GetButton("Jump"))
                myCharacter.moveDirection.y = myCharacter.jumpSpeed;
        }
		//Time.deltaTime makes it run in real time rather than every frame
        myCharacter.moveDirection.y -= myCharacter.gravity * Time.deltaTime;
        controller.Move(myCharacter.moveDirection * Time.deltaTime);
    }	
}
