using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Player : ScriptableObject {

	public int Score;
	public MovePattern MovePattern;
	public int NumOfLives = 5;
	public bool GameOver = false;
	public bool GameWon = false;
	public bool ShieldOn = false;

	
}
