using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

	public int ShieldPower;
	private bool isHit;

	void Start() {
		ShieldPower = 0;
		isHit = false;
	}

	private void Update()
	{
		while(ShieldPower > 0) {
			if(isHit) {
				ShieldPower--;
			}
		}
	}
	 private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "shield") {
			ShieldPower += 5;

		}
		else if(other.tag == "enemy") {
			isHit = true;
		}
		
	}
}
