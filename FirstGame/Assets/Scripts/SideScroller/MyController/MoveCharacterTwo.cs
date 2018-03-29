using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacterTwo : MonoBehaviour {

	public Character myCharacter;
    private CharacterController controller;
	void Start() {
		controller = GetComponent<CharacterController>();
	}

    void Update() {
        if (controller.isGrounded) {

			myCharacter.ChangePosition(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            myCharacter.moveDirection = transform.TransformDirection(myCharacter.moveDirection);
            myCharacter.moveDirection *= myCharacter.speed;
            if(myCharacter.CanJump) {
                if(myCharacter.UsesSpace) {
                    if (Input.GetButton("Jump"))
                        myCharacter.moveDirection.y = myCharacter.jumpSpeed;
                }
                else{
                    if(Input.GetAxis("Vertical") > 0) {
                        myCharacter.moveDirection.y = myCharacter.jumpSpeed;
                    }
                }
            }
        }
		//Time.deltaTime makes it run in real time rather than every frame
        myCharacter.moveDirection.y -= myCharacter.gravity * Time.deltaTime;
        controller.Move(myCharacter.moveDirection * Time.deltaTime);
    }	
}
