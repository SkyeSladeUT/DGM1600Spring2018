using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseScript : MonoBehaviour {

	public bool Key = false;
	public int Health = 100;
	public string Password = "OU812";
	public int x;
	public int y;


	// Use this for initialization
	void Start () {
		//else clauses will occur if the if statement before it does not
		//else clauses  must have an if statement before to work and they do not require an argument

		//if key is true then it will print the following
		if(Key) {
			print("The door is open");
		}
		//else it will print this
		else {
			print("You shall not pass");
		}
		//if health is greater than 0 then it will print this
		if(Health > 0) {
			print("Can play.");
		}
		//else it will print this
		else {
			print("You're dead!");
		}
		//if the password is OU812 then it will print this
		if (Password == "OU812") {
			print("That's correct.");
		}
		//else it will print this
		else {
			print("Try again.");
		}
		//if x equals y it will print this
		if (x == y) {
			print(x + " equals " + y);
		}
		//else it will print this
		else {
			print(x + " does not equal " + y);
		}
		//if x is greater than y it will print this
		if (x > y) {
			print(x + " is greater than " + y);
		}
		//else it will print this
		else {
			print(x + " is not greater than " + y);
		}
	}
}
