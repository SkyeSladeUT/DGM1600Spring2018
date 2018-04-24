using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour {

    public PowerUp PowerUpTransfer;
    public Image HealthBar;
    public Animator animator;
    public Player player;
    private Vector3 SpawnPoint = new Vector3 (-4, 0.6f, 0);
    public MovePattern NormalMove;
    public Text Lives;

    private void Start () {
        Lives.text = "Lives: " + player.NumOfLives;
    }

    private void OnTriggerEnter (Collider obj) {
		if(!player.ShieldOn) {
            if (HealthBar.fillAmount > 0) {
                obj.GetComponent<MoveCharacter> ().Player.MovePattern = PowerUpTransfer.Transfer ();
                HealthBar.fillAmount -= PowerUpTransfer.PowerLevel;
            }
        }
        if (HealthBar.fillAmount <= 0) {
            HealthBar.fillAmount = 1.0f;
            obj.gameObject.transform.position = SpawnPoint;
            player.MovePattern = NormalMove;
            player.NumOfLives--;
            Lives.text = "Lives: " + player.NumOfLives;
        }
        if (player.NumOfLives <= 0) {
            animator.SetTrigger ("ExitGame");
            player.GameOver = true;
        }
    }
}
