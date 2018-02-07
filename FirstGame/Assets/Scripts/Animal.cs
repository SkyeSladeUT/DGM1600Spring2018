using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Animal : MonoBehaviour {
//string variables are for assigning strings of letters (uses " ")
	public string Name;
//int variables are for whole numbers
	public int FoodCount;
//text variables are for displaying UI text on the screen of the game
	public Text myUIText;
//float variables are numbers which can have decimal places
	
	void OnMouseDown()
	{

		if (FoodCount >= 0) {
			myUIText.text = "The " + Name + " ate food. \nThe " + Name + " has " + FoodCount + " amount of food left.";
			FoodCount -= 1;	
		}

		if ((FoodCount < 0) && (FoodCount >=-5)) {
			myUIText.text = "The " + Name + " is starving.";
			FoodCount -= 1;
		}

		if (FoodCount < -5) {
			myUIText.text = "The " + Name + " is dead.";
		}

	}
		void Update () {
		
	}
}
