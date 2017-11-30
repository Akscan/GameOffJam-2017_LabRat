using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Interact : MonoBehaviour {
	Text displayText;
	Canvas displayCanvas;
	GameObject coin;
	GameObject hammer;
	bool inColliderAutomat;
	bool inColliderCoin;
	bool inColliderHammer;
	public int hasCoin;
	public int hasHammer;
	public Text interactText;
	public TimerManager timerDressUp;
	float timerText;
	bool keyDown;
	void Awake()
	{
		timerText = 0;
		inColliderAutomat = false;
		hasCoin = 0;
		hasHammer = 0;
		inColliderCoin = false;
		inColliderHammer = false;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "FirstAutomat" || other.gameObject.name == "SecondAutomat") {
			displayText = other.GetComponentInChildren<Text> ();
			displayText.text = "Insert coin";
			interactText.text = "E: Interract";
			inColliderAutomat = true;
			keyDown = false;
		}
		if (other.gameObject.name == "FirstCoin" || other.gameObject.name == "SecondCoin") {
			interactText.text = "E: Take";
			inColliderCoin = true;
			coin = other.gameObject;
		}
		if (other.gameObject.name == "hammer(Clone)") {
			interactText.text = "E: Take";
			inColliderHammer = true;
			hammer = other.gameObject;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.name == "FirstAutomat" || other.gameObject.name == "SecondAutomat") {
			displayText = other.GetComponentInChildren<Text> ();
			displayText.text = " ";
			interactText.text = " ";
			inColliderAutomat = false;
		}
		if (other.gameObject.name == "FirstCoin" || other.gameObject.name == "SecondCoin") {
			interactText.text = " ";
			inColliderCoin = false;
		}
		if (other.gameObject.name == "hammer(Clone)") {
			interactText.text = " ";
			inColliderHammer = false;
		}
	}

	void Update()
	{
		if (inColliderAutomat)
			timerText += Time.deltaTime;
		else
			timerText = 0;
		//Debug.Log (hasCoin);

		if (inColliderAutomat && !keyDown) {
			if (Input.GetKey (KeyCode.E)) {
				switch (hasCoin) {
				case 0:
					{
						keyDown = true;
						timerText = 0;
						displayText.fontSize = 11;
						displayText.text = "Found some Coin!";
						break;
					}
				case 1:
					{
						keyDown = true;
						timerText = 0;
						hasCoin = 0;
						displayText.fontSize = 14;
						displayText.text = "You water";
						timerDressUp.dressUpSlider.value += 30;
						timerDressUp.intDressUpTimer += 30;
						break;
					}
				}
			}
		}

		if (Input.GetKey (KeyCode.E) && inColliderCoin) {
			hasCoin = 1;
			interactText.text = " ";
			inColliderCoin = false;
			Destroy (coin);
		}
		if (Input.GetKey (KeyCode.E) && inColliderHammer) {
			hasHammer = 1;
			interactText.text = " ";
			inColliderHammer = false;
			Destroy (hammer);
		}

		if (timerText > 10f) {
			displayText.text = " ";
			keyDown = false;
		}
			
	}

}
