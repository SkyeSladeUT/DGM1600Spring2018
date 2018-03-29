using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Pattern2D : MovePattern {

	public override void Move (CharacterController controller, Transform transform) {
        if (controller.isGrounded) {

            moveDirection.x = Input.GetAxis ("Horizontal");
            moveDirection.z = 0;
            moveDirection.y = 0;

            moveDirection = transform.TransformDirection (moveDirection);
            moveDirection *= speed;
            if (Input.GetAxis ("Vertical") > 0)
                moveDirection.y = jumpSpeed;
        }
        //Time.deltaTime makes it run in real time rather than every frame
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move (moveDirection * Time.deltaTime);
    }

}
