using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
//part of the calculation
public class Add : Calculation {

	public override float Calculate(string a, string b) {

		anum = float.Parse(a);
		bnum = float.Parse(b);

		return anum + bnum;
	}
}
