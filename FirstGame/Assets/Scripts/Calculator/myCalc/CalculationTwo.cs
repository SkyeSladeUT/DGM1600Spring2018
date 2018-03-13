using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CalculationTwo : ScriptableObject {

	public string Operation;

	public float Calculate(string a, string b) {

		float anum = float.Parse(a);
		float bnum = float.Parse(b);

		switch (Operation)
		{
			case "+":
				return anum + bnum;
			case "-":
				return anum - bnum;
			case "*":
				return anum * bnum;
			case "/":
				return anum / bnum;
			default:
				return 0;
		}
	}
}
