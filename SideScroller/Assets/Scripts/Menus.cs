using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menus : MonoBehaviour {
	public Transform PauseMenu;
	public Transform ControlsMenu;
	public Transform MainMenu;
	public Transform EndScreen;
	public Animator animator;
	public Player player;
	public Text endScore; 
	public Text WinText;
	private void Start()
	{
		MainMenu.gameObject.SetActive(true);
		PauseMenu.gameObject.SetActive(false);
		ControlsMenu.gameObject.SetActive(false);
		EndScreen.gameObject.SetActive(false);
	}
	void Update () {
		if (Input.GetKeyDown("escape")) {
			if(!PauseMenu.gameObject.activeInHierarchy) {
				PauseMenu.gameObject.SetActive(true);
				animator.SetTrigger("Pause");
			}
			else {
				PauseMenu.gameObject.SetActive(false);
				animator.SetTrigger("StartGame");
			}
		}
		if(player.GameOver) {
			player.GameOver = false;
			WinText.text = "GAME OVER";
			EndScreen.gameObject.SetActive(true);
			endScore.text = "SCORE: " + player.Score;
		}
		if(player.GameWon) {
			player.GameWon = false;
			WinText.text = "YOU WIN";
			endScore.text = "";
			EndScreen.gameObject.SetActive(true);

		}
	}

	public void ExitPauseMenu() {
		PauseMenu.gameObject.SetActive(false);
		animator.SetTrigger("StartGame");
	}
	public void EnterControlsMenu() {
		animator.SetTrigger("Pause");
		ControlsMenu.gameObject.SetActive(true);
	}
	public void ExitControlsMenu() {
		ControlsMenu.gameObject.SetActive(false);
	}

	public void StartGame() {
		MainMenu.gameObject.SetActive(false);
		animator.SetTrigger("StartGame");
	}

	public void StartOver() {
		SceneManager.LoadScene("Game");
	}

	public void QuitGame() {
		animator.SetTrigger("ExitGame");
		Application.Quit();
	}
}
