using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
//part of the calculation class
public class Subtract : Calculation {

//overrides allows the abstract class to access it
	public override float Calculate (string a, string b) {
		
		anum = float.Parse(a);
		bnum = float.Parse(b);

		return anum - bnum;
	}
}
