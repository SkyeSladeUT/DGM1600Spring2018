using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class MovePattern : ScriptableObject {

	public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    protected Vector3 moveDirection = Vector3.zero;
    public InputBase InputX;
    public InputBase InputZ;
    public InputBase InputY;

public void Move (CharacterController controller, Transform transform) {
	if (controller.isGrounded) {

		moveDirection.x = InputX.SetFloat();
		moveDirection.z = InputZ.SetFloat();
		moveDirection.y = InputY.SetFloat();

        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        if (Input.GetButton("Jump"))
            moveDirection.y = jumpSpeed;
    }
	//Time.deltaTime makes it run in real time rather than every frame
    //apply gravity
    moveDirection.y -= gravity * Time.deltaTime;
    //moves the character
    controller.Move(moveDirection * Time.deltaTime);
}


}
