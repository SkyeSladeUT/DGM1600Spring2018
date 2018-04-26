using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	public GameObject[] Door1;
	public GameObject[] Door2;
	private Animation animate;
	public ButtonScript button;
	private bool isButtonActive;
	private AudioSource buttonNoise;


	private void Start () {
		animate = gameObject.GetComponent<Animation> ();
		buttonNoise = gameObject.GetComponent<AudioSource> ();
		foreach (var door in Door2) {
			door.SetActive (false);
		}

	}
	private void OnTriggerExit (Collider other) {
		StartCoroutine ("ButtonPress");
	}

	IEnumerator ButtonPress() {
		buttonNoise.Play();
		if(isButtonActive)
			animate.Play("On");
		else
			animate.Play("Off");
		foreach (var door in Door1) {
			door.SetActive (button.CurrentButtonActive);
		}
		foreach (var door in Door2) {
			door.SetActive (!button.CurrentButtonActive);
		}
		button.CurrentButtonActive = !button.CurrentButtonActive;
		isButtonActive = !isButtonActive;
		yield return new WaitForSeconds(1.0f);
	}
}