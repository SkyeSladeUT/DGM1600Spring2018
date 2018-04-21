using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayParticle : MonoBehaviour {

	public ParticleSystem ParticleSystem;
	private AudioSource playNoise;

	private void Start()
	{
		playNoise = gameObject.GetComponent<AudioSource>();
	}

	private void OnTriggerEnter(Collider other)
	{
		ParticleSystem.Emit(10);
		playNoise.Play();
	}
}
