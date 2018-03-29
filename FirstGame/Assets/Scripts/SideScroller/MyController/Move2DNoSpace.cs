using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Move2DNoSpace : Character {

	public override void ChangePosition(float x, float z) {
		moveDirection.x = x;
		moveDirection.z = 0;
		moveDirection.y = 0;
		UsesSpace = false;
		CanJump = true;

	}
}
