using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
//part of the calculation
public class Add : Calculation {

	public override string FinishCalculation() {

		return (anum + bnum).ToString();
	}
}
