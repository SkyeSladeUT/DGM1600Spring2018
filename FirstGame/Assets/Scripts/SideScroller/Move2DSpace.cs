using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Move2DSpace : Character {

	public override void ChangePosition(float x, float z) {
		moveDirection.x = x;
		moveDirection.z = 0;
		moveDirection.y = 0;
		UsesSpace = true;
		CanJump = true;

	}

}
