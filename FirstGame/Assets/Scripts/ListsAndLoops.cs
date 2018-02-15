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
