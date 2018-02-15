using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListsAndLoops : MonoBehaviour {

	//arrays and lists are both collections
	//array []
	//used for data stored at the beginning, before the game starts
	public string[] PlayerNames;
	//list <>
	//used for collecting things
	//can be changed within the game
	public List<string> PlayerNameList;
	//lists can contain any type of variable of the same kind
	public List<int> Scores;
	public List<double> multipliers;
	public List<int> HighScores;
	public List<string> Objects;
	public List<string> tools;
	public List<int> randomNumbers;
	public List<string> UserNames;
	public List<string> Passwords;
	public List<float> randomMultipliers;
	public TheIncredibles TheIncredibles;
	public Text AddMember;

	void Start()
	{
		//adds onto the end of the list
		PlayerNameList.Add("Dash");
		//removes the specific name in the list
		PlayerNameList.Remove("Helen");
		

	}
	void OnMouseDown()
	{
		//using scriptable objects
		//scriptable objects will keep the addition after the game stops
		TheIncredibles.FamilyList.Add(AddMember.text);
	}

}
