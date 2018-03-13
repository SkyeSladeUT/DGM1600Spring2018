using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Divide : Calculation {

	public override float Calculate(string a, string b) {

		anum = float.Parse(a);
		bnum = float.Parse(b);

		return anum / bnum;
	}
}
