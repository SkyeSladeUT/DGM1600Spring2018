using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : ScriptableObject {

	public int PowerLevel = 1.5;

	public float IncreasePower(float n) {
		n *= PowerLevel;
	}

}
