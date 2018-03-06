using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuntionsWithParameters : MonoBehaviour {

	public int Health = 20;
	public Player myPlayer;
	private float sum = 0;
	public float[] HighScores;
	public List<int> PlayerScores;
	//functions with parameters
	//a function can take an object inside the parantheses
	//Collider is an identifier and other is the object name
	void OnTriggerEnter(Collider other)
	{
		//print("Hit Something");
		//print(other);

		//AddNumbers(14, 10);
		//PlayerData("George");
		//printFace("smile");
		//Average(HighScores);
		//PrintScores(PlayerScores);
		//TrueFalse(true);
		//AddHealth(25);
		//printInfo(myPlayer);
		//SubNumbers(23, 19);

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

	void printInfo(Player player) {
		print(myPlayer.UserName);
		print(myPlayer.Health);
	}

	void SubNumbers(int a, int b) {
		print(a -= b);
	}

	void Average(float[]  arr) {
		foreach(var num in arr) {
			sum += num;
			print("The average is " + sum / arr.Length);
		}
	}

	void printFace(string emotion) {
		switch(emotion){
			case "happy":
				print(":)");
				break;
			case "sad":
				print(":(");
				break;
			case "wink":
				print(";)");
				break;
			default: 
				print(":|");
				break;
		}
	}

	void TrueFalse(bool response) {
		if(response) {
			print("I am Correct!");
		}
		else{
			print("I am Incorrect");
		}
	}

	void PrintScores(List<int> scores) {
		foreach(var score in scores) {
			print(score);
		}
	}
}
