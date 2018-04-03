using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	private CharacterController controller;
    public MovePattern MovePattern;   


	private void Start() {
		controller = GetComponent<CharacterController>();
	}

    void Update() {
        MovePattern.Move(controller, transform);
    }



}
