using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseScript : MonoBehaviour {

	public bool Key = false;
	public int Health = 100;
	public string Password = "OU812";


	// Use this for initialization
	void Start () {

		if(Key) {
			print("The door is open");
		}
		else {
			print("You shall not pass");
		}
		if(Health > 0) {
			print("Can play.");
		}
		else {
			print("You're dead!");
		}
		if (Password == "OU812") {
			print("That's correct.");
		}
		else {
			print("Try again.");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
