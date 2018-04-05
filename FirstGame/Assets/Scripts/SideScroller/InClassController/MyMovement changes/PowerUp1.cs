using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class PowerUp1 : ScriptableObject {

	public float PowerLevel = 2.0F;
	public string name;

	public float IncreasePower(float n) {
		return n*PowerLevel;
	}

	public float DecreasePower(float n) {
		return n/PowerLevel;
	}

}
