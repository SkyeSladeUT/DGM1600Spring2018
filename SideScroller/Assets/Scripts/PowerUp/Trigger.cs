using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

	public PowerUp PowerUpTransfer;
	public Image HealthBar;
	public Animator animator;
	public Player player;
	private Vector3 SpawnPoint = new Vector3(-4, 0.6f, 0);
	public MovePattern NormalMove;


	private void OnTriggerEnter(Collider obj)
	{
		
		if(HealthBar.fillAmount > 0) {
			obj.GetComponent<MoveCharacter>().Player.MovePattern = PowerUpTransfer.Transfer();
			HealthBar.fillAmount -= PowerUpTransfer.PowerLevel;

		}
		if(HealthBar.fillAmount <= 0) {
			obj.gameObject.transform.position = SpawnPoint;
			HealthBar.fillAmount = 1.0f;
			player.MovePattern = NormalMove;
		}
		gameObject.SetActive(!PowerUpTransfer.ObjectDestroy);
	}

}
