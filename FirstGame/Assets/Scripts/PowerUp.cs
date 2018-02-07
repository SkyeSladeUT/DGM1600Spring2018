using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//scriptable objects cannot be used as components
[CreateAssetMenu]
public class PowerUp : ScriptableObject {

	public int PowerLevel = 100;
	public string Name = "Health";

}
