using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuntionsWithParameters : MonoBehaviour {

	public int Health = 20;
	//functions with parameters
	//a function can take an object inside the parantheses
	//Collider is an identifier and other is the object name
	void OnTriggerEnter(Collider other)
	{
		//print("Hit Something");
		//print(other);

		//AddNumbers(14, 10);
		//PlayerData("George");
		AddHealth(25);
	}

	void AddNumbers(int a, int b) {
		print(a += b);
	}

	void PlayerData(string name) {
		print("This player is " + name);
	}

	void AddHealth(int newHealth) {
		Health += newHealth;
	}
}
