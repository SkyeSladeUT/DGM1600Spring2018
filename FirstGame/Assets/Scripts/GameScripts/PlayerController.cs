using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    Rigidbody RB;
    public float jumpSpeed;
    public float sideSpeed;
    private bool isGrounded;
    private int jumpCount;
    public Player myPlayer;

    void Start () {
        RB = GetComponent<Rigidbody> ();
        isGrounded = true;
        jumpCount = 0;
    }

    void Update () {

        Jump ();
        Move ();
    }
    void Jump () {
        if (isGrounded || jumpCount < 2) {
            if (Input.GetButtonDown ("Vertical" + myPlayer.PlayerNum)) {
                if (Input.GetAxisRaw ("Vertical" + myPlayer.PlayerNum) > 0) {
                    RB.velocity = Vector3.up * jumpSpeed;
                    isGrounded = false;
                    ++jumpCount;
                }
            }
        }
    }

    void OnCollisionEnter (Collision other) {
        isGrounded = true;
        jumpCount = 0;
    }

    void OnCollisionExit(Collision other){
        isGrounded = false;
    }

    void Move () {
        if (isGrounded) {
            if (Input.GetButton ("Horizontal" + myPlayer.PlayerNum)) {
                if (Input.GetAxisRaw ("Horizontal" + myPlayer.PlayerNum) > 0) {
                    RB.velocity = Vector3.right * sideSpeed;
                } else {
                    RB.velocity = Vector3.left * sideSpeed;
                }
            }
        } else {
            if (Input.GetButtonDown ("Horizontal" + myPlayer.PlayerNum)) {
                if (Input.GetAxisRaw ("Horizontal" + myPlayer.PlayerNum) > 0) {
                    RB.velocity = Vector3.right * sideSpeed;
                } else {
                    RB.velocity = Vector3.left * sideSpeed;
                }
            }
        }
    }
}