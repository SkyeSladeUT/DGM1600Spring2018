using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MovePattern2 : ScriptableObject {

	public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    protected Vector3 moveDirection = Vector3.zero;

public abstract void Move (CharacterController controller, Transform transform);
}
