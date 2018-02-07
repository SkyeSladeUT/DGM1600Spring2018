using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

	public int Heart;
	public int Health;
	public string Password = "Love";

	void Start () {
		// == compares the two objects on each side of the ==
		// || means or therefore if one of the following is true then the statement will occur
		if(Password == "love" || Password == "Love" || Password == "LOVE") {
			Heart = 100;
			Health += 10;
		}
		//>= is greater than or equal to
		if(Health >= 100) {
			print("You have full health");
		}
		//<= is less than or equal to
		if(Health <= 0) {
			print("You have no health");
		}
		// < is less than
		if(Heart < 100) {
			print("You do not have a full heart");
		}
		// > is greater than
		if(Heart > 0) {
			print("You still have a heart");
		}
		//!= means not equal to
		if(Password != "love") {
			print("Incorrect password");
		}
		// && stands for and therefore both statements have to be true to print
		if(Health >= 100 && Heart >= 100) {
			print("You have a full heart and health");
		}
		// You can use multiple different operators in the same if statement
		if((Health < 100 || Heart < 100) && Password == "love" ) {
			print("Your heart and health have been restored");
			Health = 100;
			Heart = 100;
		}
		if(Health >= 100 && Heart >= 100 && Password == "love") {
			print("You are already at full Heart and Health");
		}
		if(Health != Heart) {
			print("Your Heart is not in your Health");
		}

		
	}

}
