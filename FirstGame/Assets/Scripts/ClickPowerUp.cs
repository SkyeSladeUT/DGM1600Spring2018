using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPowerup : MonoBehaviour {

	public PowerUp MyPowerUp;

	void OnMouseDown()
	{
		MyPowerUp.RunPowerUp();
	}
}
