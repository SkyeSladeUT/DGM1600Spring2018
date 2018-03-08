using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Calculation : ScriptableObject {

	public string Operation;

	public int Calculate(string a, string b) {

		int anum = int.Parse(a);
		int bnum = int.Parse(b);

		switch (Operation)
		{
			case "+":
				return anum + bnum;
			case "-":
				return anum - bnum;
			case "*":
				return anum * bnum;
			default:
				return 0;
		}
	}
}
