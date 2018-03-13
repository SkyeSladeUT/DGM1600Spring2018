using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//abstract means that the class is generic
//you do not create assets for this class

//change to non abstract and parse nums
public abstract class Calculation : ScriptableObject {

	public float anum;
	public float bnum;

	public abstract float Calculate(string a, string b);
	//parse the numbers in this function and return FinishCalc()
//create an abstract definition FinishCalc() and change all the scriptatble objects to have this function instead of Calculate
}
