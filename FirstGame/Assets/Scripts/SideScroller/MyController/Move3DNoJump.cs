using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Move3DNoJump : Character {

	public override void ChangePosition(float x, float z) {
		moveDirection.x = x;
		moveDirection.z = z;
		moveDirection.y = 0;
		UsesSpace = true;
		CanJump = false;
	}

}
