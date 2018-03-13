using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithReturns : MonoBehaviour {

	public int MyInt = 100;
	public int Health;

	void Start () {
		//void functions do work
		//and return nothing

		//this will assign MyInt with the return value from AddHealth
		MyInt = AddHealth(10);
	}

	//this function does the same as the assignment statement
	public int AddHealth(int value) {

		print("Added Health");
		//the function can not only return a value but it can do other work such as
		//move a character
		//play an animation
		//change text (if showing the health on the screen)

		return Health += value;
	}

	void OnMouseDown()
	{
		Health = AddHealth(10);
		Players.Add(NewPlayer("Bob"));
	}

	public List<string> Players;

	public List<string> NewPlayers () {
		return new List<string>();
	}

	public string NewPlayer (string name) {
		return name;
	}

	public int AddNum(int a, int b) {
		return a + b;
	}

	public float Divide(float a, float b) {
		return a / b;
	}

	public int SubNum(int a, int b) {
		return a - b;
	}

	public int multiply(int a, int b) {
		return a * b;
	}

	public float QuadraticEquationPositive (float a, float b, float c) {
		float x = -b + Mathf.Sqrt((b*b) - (4 * a * c));
		x = x/(2*a);
		return x;
	}

	public string MadLibs(string noun, string adjective, string verb) {
		string phrase;
		phrase = "The " + adjective + " " + noun + " is " + verb + ".";
		return phrase;
	}

	public int getNewNumber(int a) {
		a += 12;
		a *= 2;
		a -= 10;
		return a;
	}

}
