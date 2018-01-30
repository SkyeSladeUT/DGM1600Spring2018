using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyClass : MonoBehaviour {

	public bool Key = false;
	public bool Ax = false;
	public Text myUIText;
	void OnMouseDown()
	{
		if(Key == true) {
			myUIText.text = "Open Door";
		}
		if((Key == false) && (Ax == true)) {
			myUIText.text = "Chop down the door";
		}
		if((Key == false) && (Ax == false)) {
			myUIText.text = "Door cannot be opened";
		}
	}


}
