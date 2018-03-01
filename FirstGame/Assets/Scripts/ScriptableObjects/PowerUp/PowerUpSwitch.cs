using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSwitch : MonoBehaviour {

	public PowerUpBase MyPowerUp;
	
	void Start () {
		switch (MyPowerUp.PowerLevel)
		{
			case 100:
				print("You just got more ammo");
				break;

			case 1000:
				print("You hit a special, and get 1000 ammo");
				break;
			
		}	
	}
}

