﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovePattern : ScriptableObject {

	public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    protected Vector3 moveDirection = Vector3.zero;

public abstract void Move (CharacterController controller, Transform transform); /*{
	if (controller.isGrounded) {

		moveDirection.x = Input.GetAxis("Horizontal");
		moveDirection.z = Input.GetAxis("Vertical");
		moveDirection.y = 0;

        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        if (Input.GetButton("Jump"))
            moveDirection.y = jumpSpeed;
    }
		//Time.deltaTime makes it run in real time rather than every frame
    moveDirection.y -= gravity * Time.deltaTime;
    controller.Move(moveDirection * Time.deltaTime);
}*/


}