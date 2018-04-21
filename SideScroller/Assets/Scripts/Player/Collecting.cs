using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collecting : MonoBehaviour {

	public Player player;
	public Text scoreText;
	public int winScore;
	public Animator animator;
	public ParticleSystem ParticleSystem;
	private AudioSource SFX;

	void Start () {
		player.Score = 0;
		scoreText.text = "Score: " + player.Score;
		SFX = gameObject.GetComponent<AudioSource>();
	}
	void OnTriggerEnter(Collider other)
	{
		switch(other.tag) {
			case "coin":
				SFX.Play();
				ParticleSystem.Emit(10);
				Destroy(other.gameObject);
				player.Score += 100;
				break;
			case "gem":
				SFX.Play();
				ParticleSystem.Emit(10);
				Destroy(other.gameObject);
				player.Score += 500;
				break;
			case "life":
				SFX.Play();
				ParticleSystem.Emit(10);
				Destroy(other.gameObject);
				player.NumOfLives ++;
				break;
			case "health":
				SFX.Play();
				ParticleSystem.Emit(10);
				break;
			default:
				break;
		}
		scoreText.text = "Score: " + player.Score;
		if(player.Score == winScore) {
			player.GameWon = true;
			animator.SetTrigger("ExitGame");
		}
	}

}
