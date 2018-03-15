using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccess : ScriptableObject {
//the scope is where a variable or function can be used
//Access Modifiers affect where a variable or function can be used
	//public allows all scripts to use it
	//public class also allows the variable to be changed in unity
	public int HighScore;
	//HighScores will be able to be used in any script that contains ScopeAndAccess object

	public string PlayerName;
	public int PlayerScore;

	//private means only the script which the variables/functions are defined can use it
	private int Multiplier = 2;
	//multiplier can only be used in this script

	private int MaxScore;

	//protected allows only subclasses to see the variables
	protected string UserName;
	//UserName can be used by this script and children of this script

	protected string Password;
	//FindHighScore can be called in another script (such as a monobehaviour script)
	public int FindHighScore(int[] scores) {
		//max can only be used in this function because it is defined in the function
		int max = 0;
		foreach (var score in scores){
			if(score > max) {
				max = score;
			}
		}
		return max;
	}

	public string GetUserInfo() {
		return "Player Name: " + PlayerName + "\n" + "Score: " + PlayerScore;
	}

	//MultiplyScore can only be used in this script
	private int MultiplyScore(int score) {
		return score * Multiplier;
	}

	//GetUserName can be used in this script and children of this script
	protected string GetUserName() {
		return UserName;
	}

}
