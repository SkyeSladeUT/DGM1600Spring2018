using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathOperators : MonoBehaviour {

	public int A;
	public int B;
	public int C;

	void Start () {
		//addition
		C = A + B;
		//subtraction
		A = B - C;
		//multiplictation
		B = C * A;
		//division (only works if ints can be divided fully or if floats)
		C = A / B;
		//increments C by 1 (C + 1)
		C++;
		//decrements B by 1 (B - 1)
		B--;
		//Short cut for A = A + 10
		A += 10;
		//ShortCut for B = B - 5
		B -= 5;
		// C = C + A + B
		C += A + B;
		// C = C * 8
		C *= 8;
		// A = A / 5
		A /= 5;

	}

}
