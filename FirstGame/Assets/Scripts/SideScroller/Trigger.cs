using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public Image HealthBar;

	private void OnTriggerEnter(Collider obj)
	{
		
		if(HealthBar.fillAmount > 0) {
			obj.GetComponent<MoveCharacter>().MovePattern = PowerUpTransfer.Transfer();
			HealthBar.fillAmount -= PowerUpTransfer.PowerLevel;
		}
		gameObject.SetActive(false);
	}

}
