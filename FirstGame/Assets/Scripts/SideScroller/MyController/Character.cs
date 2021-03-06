﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : ScriptableObject {

	public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public Vector3 moveDirection = Vector3.zero;
    public bool UsesSpace;
    public bool CanJump;

	public abstract void ChangePosition(float x, float z);
}
