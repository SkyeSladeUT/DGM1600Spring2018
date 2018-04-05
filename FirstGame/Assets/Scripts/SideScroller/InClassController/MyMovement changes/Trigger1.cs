using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour {

	public MovePattern MovePattern;
	public PowerUp1 MyPowerUp;
    private void OnTriggerEnter(Collider other)
    {
        switch(MyPowerUp.name) {
            case "speed":
                MovePattern.speed = MyPowerUp.IncreasePower(MovePattern.speed);
                Destroy(gameObject);
                break;
            case "jump":
                MovePattern.jumpSpeed = MyPowerUp.IncreasePower(MovePattern.jumpSpeed);
                Destroy(gameObject);
                break;
            default:
                break;
        } 
    }
}
