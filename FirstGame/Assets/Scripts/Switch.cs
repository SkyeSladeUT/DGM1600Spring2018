using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {

	public string UserName;

	// Use this for initialization
	void Start () {
		//switch statements are an alternative to if statements
		//switch statements make it really easy to add new cases
		//they can be used with any variable type
		//the variable within the paranthesis (UserName) is what is being tested
		switch (UserName)
		{
			//if Username is Password then this branch will be taken
			case "Password":
				print("Password is correct");
				//break stops the switch statement
				break;

			//if UserName is LevelUp then this branch will take
			case "LevelUp":
				print("You win!!! Next Level");
				break;
			
			//if UserName is BlackPanther then this branch will be taken
			case "BlackPanther":
				print("Made over 200 million this weekend");
				break;
			
			//if none of the other branches are taken then this will run
			default:
				print("Why don't you just tell me which movie you want to see?");
				break;
		}
	}
}
