using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Animal : MonoBehaviour {

	public string Name;
	public int FoodCount;
	public Text myUIText;
	
	void OnMouseDown()
	{
		if (FoodCount >= 0) {
			myUIText.text = "The " + Name + " ate food. \nThe " + Name + " has " + FoodCount + " amount of food left.";
			FoodCount -= 1;
		}

		if ((FoodCount < 0) && (FoodCount >=-5)) {
			print("The " + Name + " is starving.");
			FoodCount -= 1;
		}

		if (FoodCount < -5) {
			print("The " + Name + " is dead.");
		}

	}
		void Update () {
		
	}
}
