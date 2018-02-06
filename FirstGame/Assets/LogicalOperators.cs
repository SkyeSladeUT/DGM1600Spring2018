using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperators : MonoBehaviour {

	public int Heart;
	public int Health;
	public string Password = "Love";

	void Start () {

		if(Password == "love" || Password == "Love" || Password == "LOVE") {
			Heart = 100;
			Health += 10;
		}
		
	}

	void Update () {
		
	}
}
