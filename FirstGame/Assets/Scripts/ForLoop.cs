using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour {
//for loops
//syntax:
/*for(integer = STARTING_VALUE; integer < UPPER_LIMIT; interger++ [increment integer]) {
	//do work
} 
for loops can often be converted into foreach loops*/
//for loops are used to run through a program a certain number of times

	public string[] Names;
	public string[] Keys;
	private int i;
	private int health;

	void Start () {
		for(i = 0; i < Names.Length; i++) {
			print(Names[i]);
		}
		//this loop does the same as above
		foreach (var name in Names){
			print(name);
		}
		for(health = 0; i < Keys.Length; health++){
			if(Keys[i] == "Add Ammo") {
				print(Keys[i]);
			}
		}
		//function call
		run();
	}
//void functions return no value
//function declaration
	void run() {
		//do work
	}
}
