using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Multiply : Calculation {

	public override float Calculate(string a, string b) {

		anum = float.Parse(a);
		bnum = float.Parse(b);

		return anum * bnum;
	}
}
