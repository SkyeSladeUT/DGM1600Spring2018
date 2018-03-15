using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//abstract means that the class is generic
//you do not create assets for this class
public abstract class Calculation : ScriptableObject {
//public and private are access modifiers
	//determine whether other scripts can access the data
	//public allows all scripts to use it
	//private means only the script which the variables/functions are defined can use it
	//protected allows only subclasses to see the variables
	protected float anum;
	protected float bnum;


	//concrete functions have definitions and cannot be abstract
	public string Calculate(string a, string b) {
		anum = float.Parse(a);
		bnum = float.Parse(b);

		return FinishCalculation();
	}
	//abstract functions are not concrete and are only declared not defined
	//they are defined in subclasses
		//in the subclasses the functions need to have override in them
			// ex: public override string FinishCalculation() { code }
	public abstract string FinishCalculation();
}
