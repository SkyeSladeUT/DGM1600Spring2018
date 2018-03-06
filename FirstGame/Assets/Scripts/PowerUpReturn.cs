using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpReturn : MonoBehaviour {

	public int PowerLevel = 10;
	public Player CurrentPlayer;
	public int PowerLevelIncrease = 2;


	public int IncreasePowerLevel() {
		PowerLevel += PowerLevelIncrease;
		PowerLevel *= PowerLevelIncrease;
		return PowerLevel;
	}

	void OnMouseDown()
	{
		CurrentPlayer.Health = IncreasePowerLevel();
	}


}
