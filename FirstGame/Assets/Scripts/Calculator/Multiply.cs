using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Multiply : Calculation {

	public override string FinishCalculation() {

		return (anum * bnum).ToString();
	}
}
