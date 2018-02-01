using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyClass : MonoBehaviour {
	//bools can have only one of two values: true or false
	public bool Key = false;
	public bool Ax = false;
	public bool KarateMaster = false;
	public Text myUIText;
	public int x;
	public int y;

	void Start()
	{
		
	}
	void OnMouseDown()
	{
		//if statements will run if the argument inside it is true
		//if key is true the text will change
		if(Key == true) {
			myUIText.text = "Open Door";
		}
		// if key is false and ax is true the text will change
		else if(Ax == true) {
			myUIText.text = "Chop down the door";
		}
		//if both key and ax are false and karatemaster is true then the text will change
		else if(KarateMaster == true) {
			myUIText.text = "Kick down the door";
		}
		//if all three are false then this will print
		else {
			myUIText.text = "You cannot open the door.";
		}
		//since 3 + 1 is always 4 this will always print hooray
		if(3 + 1 == 4) {
			print("Hooray");
		}
		//since 3 + 1 is never 5 then this will never print
		if(3 + 1 == 5) {
			print("Boo");
		}
		//if x is greater than y then this will print
		if(x > y) {
			print(x + " is greater than " + y);
		}
		//if x is less than y then this will print
		if(x < y) {
			print(x + " is less than " + y);
		}
		//if x equals y this will print
		if( x == y) {
			print(x + " equals " + y);
		}
		//this will always print because it is always true
		if(!false) {
			print("You did it!");
		}

	}
	void Update()
	{
		
	}


}
