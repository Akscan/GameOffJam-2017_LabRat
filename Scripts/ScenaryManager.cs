using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

public class ScenaryManager : MonoBehaviour {

	public GameObject Player;
	public GameObject Enviroment;
	public AudioSource SoundBlaster;
	public AudioClip[] BuffAudio;
	public GameObject Hammer;
	float secondTimer;
	float firstStepScenarioTimer;
	int   stepScenatio;

	// Use this for initialization
	void Awake () {
		secondTimer = 0;
		firstStepScenarioTimer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		secondTimer += Time.deltaTime;
		firstStepScenarioTimer += Time.deltaTime;
		if (firstStepScenarioTimer > 5 && stepScenatio == 0) {
			FirstStepScenario ();
		}
		if (stepScenatio == 1) {
			SecondStepScenario ();
		}
		if (stepScenatio == 2) {
			ThirdStepScenario ();
		}
		if (stepScenatio == 3) {
			FourStepScenario ();
		}
		if (stepScenatio == 4) {
			FiveStepScenario ();
		}
		if (stepScenatio == 5) {
			SixStepScenario ();
		}
		if (stepScenatio == 6){
			SevenStepScenario ();
		}
		if (stepScenatio == 7) {
			EightStepScenario ();
		}
		if (stepScenatio == 8) {
			EightStepScenario ();
		}
		if (stepScenatio == 9) {
			NineStepScenario ();
		}
		if (stepScenatio == 10) {
			TenStepScenario ();
		}
		if (stepScenatio == 11) {
			EllevenStepScenario ();
		}
		if (stepScenatio == 12) {
			TwelweStepScenario ();
		}
		if (stepScenatio == 13) {
			ThiordStepScenario ();
		}
		if (stepScenatio == 14) {
			FourthStepScenario ();
		}
		if (stepScenatio == 15) {
			FifthStepScenario ();
		}
		//Debug.Log (stepScenatio);
	}

	void FirstStepScenario ()
	{
		SoundBlaster.clip = BuffAudio [0];
		SoundBlaster.PlayScheduled (0);
		stepScenatio = 1;
	}

	void SecondStepScenario()
	{
		if (SoundBlaster.isPlaying == false) {
			SoundBlaster.clip = BuffAudio [1];
			SoundBlaster.Play();
			stepScenatio = 2;
		}
	}

	void ThirdStepScenario()
	{
		if (SoundBlaster.isPlaying == false) {
			SoundBlaster.clip = BuffAudio [2];
			SoundBlaster.Play();
			stepScenatio = 3;
		}
	}

	void FourStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("FirstAutomat");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if (distance < 10) {
			stepScenatio = 4;
			SoundBlaster.clip = BuffAudio [3];
			SoundBlaster.Play ();
		}
	}

	void FiveStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("FirstCoin");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if (distance < 2) {
			stepScenatio = 5;
			SoundBlaster.clip = BuffAudio [4];
			SoundBlaster.Play ();
		}
	}

	void SixStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("FirstAutomat");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if (distance < 2) {
			if (SoundBlaster.isPlaying == false) {
				SoundBlaster.clip = BuffAudio [5];
				SoundBlaster.Play();
				stepScenatio = 6;
			}
		}
	}

	void SevenStepScenario()
	{
		if (SoundBlaster.isPlaying == false) {
			SoundBlaster.clip = BuffAudio [6];
			SoundBlaster.Play();
			stepScenatio = 7;
		}
	}
	
	void EightStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find("SecondAutomat");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if(distance > 300){
			if(SoundBlaster.isPlaying == false){
				SoundBlaster.clip = BuffAudio[7];
				SoundBlaster.Play();
			}
		}
		if(distance <= 300 && distance > 200){
			if(SoundBlaster.isPlaying == false){
				SoundBlaster.clip = BuffAudio[8];
				SoundBlaster.Play();
			}
		}
		if(distance <= 200 && distance > 30){
			if(SoundBlaster.isPlaying == false){
				SoundBlaster.clip = BuffAudio[9];
				SoundBlaster.Play();
			}
		}
		if(distance <= 30 && distance > 5){
			if(SoundBlaster.isPlaying == false){
				SoundBlaster.clip = BuffAudio[10];
				SoundBlaster.Play();
				stepScenatio = 9;
			}
		}
	}

	void NineStepScenario()
	{
		if (SoundBlaster.isPlaying == false) {
			SoundBlaster.clip = BuffAudio [11];
			SoundBlaster.Play();
			stepScenatio = 10;
		}
	}

	void TenStepScenario()
	{
		if (SoundBlaster.isPlaying == false) {
			SoundBlaster.clip = BuffAudio [12];
			SoundBlaster.Play();
			stepScenatio = 11;
		}
	}

	void EllevenStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("SecondCoin");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if (distance < 2) {
			if (SoundBlaster.isPlaying == false) {
				SoundBlaster.clip = BuffAudio [13];
				SoundBlaster.Play();
				stepScenatio = 12;
			}
		}
	}

	void TwelweStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("SecondAutomat");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if (distance < 5) {
			stepScenatio = 13;
			SoundBlaster.clip = BuffAudio [14];
			SoundBlaster.Play ();
		}
	}

	void ThiordStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("FirstAutomat");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if (distance < 300) {
			stepScenatio = 14;
			SoundBlaster.clip = BuffAudio [15];
			GameObject tempHammer = Instantiate (Hammer);
			tempHammer.transform.position = new Vector3 (362.5408f, 10.14f, 934.7747f);
			tempHammer.transform.localScale += new Vector3 (15f, 15f, 15f);
			SoundBlaster.Play ();
		}
	}

	void FourthStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("FirstAutomat");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		if (distance < 2) {
			SoundBlaster.clip = BuffAudio [17];
			SoundBlaster.Play ();
			stepScenatio = 15;
		}
	}

	void FifthStepScenario()
	{
		Transform tempObject = Enviroment.transform.Find ("Exit");
		GameObject Object = tempObject.gameObject;
		float distance = foundDistanceBetweenTwoPoints(Player, Object);
		Debug.Log (distance);
		if (distance < 200) {
			SoundBlaster.clip = BuffAudio [18];
			SoundBlaster.Play ();
			stepScenatio = 16;
		}
	}
		



	float foundDistanceBetweenTwoPoints(GameObject first, GameObject second)
	{
		Vector3 firstPosition  = first.transform.position;
		Vector3 secondPosition = second.transform.position;
		float distance = Vector3.Distance (firstPosition, secondPosition);
		//Debug.Log (distance);
		return distance;
	}

}
