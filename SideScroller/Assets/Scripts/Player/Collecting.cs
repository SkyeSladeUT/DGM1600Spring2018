using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collecting : MonoBehaviour {

    public Player player;
    public Text scoreText;
    public Text LifeText;
    public int winScore;
    public Animator animator;
    public ParticleSystem ParticleSystem;
    private AudioSource SFX;
    private int ShieldPower;
    public Transform ShieldOutline;
    public Text ShieldCountDown;
    private enum Collections {coin = 10, gem = 50, health = 10, life = 50, none = 0};
    private Collections value;

    void Start () {
        player.Score = 0;
        scoreText.text = "Score: " + player.Score;
        SFX = gameObject.GetComponent<AudioSource> ();
        ShieldPower = 0;
        ShieldOutline.gameObject.SetActive(false);
        player.ShieldOn = false;
    }
    void OnTriggerEnter (Collider other) {
        switch (other.tag) {
            case "coin":
                SFX.Play ();
                ParticleSystem.Emit (10);
                Destroy(other.gameObject);
                value = Collections.coin;
                break;
            case "gem":
                SFX.Play ();
                StartCoroutine("Fireworks");
                Destroy(other.gameObject);  
                value = Collections.gem;
                break;
            case "life":
                SFX.Play ();
                StartCoroutine("Fireworks");
                Destroy(other.gameObject);
                value = Collections.life;
                player.NumOfLives++;
                LifeText.text = "Lives: " + player.NumOfLives;
                break;
            case "health":
                SFX.Play ();
                ParticleSystem.Emit (10);
                Destroy(other.gameObject);
                value = Collections.health;
                break;
            case "shield":
                SFX.Play ();
                ParticleSystem.Emit (10);
                Destroy(other.gameObject);
                value = Collections.none;
            	ShieldPower = 10;
                player.ShieldOn = true;
                ShieldOutline.gameObject.SetActive(true);
			    StartCoroutine ("Shield");
                break;
            default:
                value = Collections.none;
                break;
        }

        player.Score += (int)value;
        scoreText.text = "Score: " + player.Score;
        if (player.Score >= winScore) {
            player.GameWon = true;
            animator.SetTrigger ("ExitGame");
        }
    }
	IEnumerator Fireworks() {
		for(int i = 3; i > 0; i--) {
			ParticleSystem.Emit(10);
			yield return new WaitForSeconds(.2f);
		}
	}

    IEnumerator Shield() {
		while (ShieldPower > 0) {
            ShieldCountDown.text = ShieldPower.ToString();
            ShieldPower--;
            if(ShieldPower <= 0 ) {
                player.ShieldOn = false;
                ShieldOutline.gameObject.SetActive(false);
                ShieldCountDown.text = "";
            }
 
			yield return new WaitForSeconds(1.0f);
		}
	}


}