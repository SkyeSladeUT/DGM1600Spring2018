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
	public int MaxSize;
	public int Ammo;
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
				Ammo += 10;
			}
			if(Keys[i] == "Add Health") {
				health += 10;
			}
		}
		for(health = 100; health > 0; health -= 10) {
			print("Health: " + health);
		}
		//function call
		run();
	}
//void functions return no value but can do work
//function declaration
	void run() {
		for(i = 0; i < MaxSize; i++) {
			print(i);
		}
	}
	//this is a built in function for a monobehaviour [so is start]
	void Update()
	{
		//do work
	}
	void Move() {
		//move character
	}
	void Jump() {
		//make character jump
	}
}
