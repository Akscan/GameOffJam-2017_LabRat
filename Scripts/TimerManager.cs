using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerManager : MonoBehaviour {
	public Slider dressUpSlider;
	public int intDressUpTimer;
	float tempDelta;
	// Use this for initialization
	void Start () {
		intDressUpTimer = 600;
		dressUpSlider.maxValue = intDressUpTimer;
		dressUpSlider.value = intDressUpTimer;
		tempDelta = 0;
	}
	
	// Update is called once per frame
	void Update () {
		tempDelta += Time.deltaTime;
		if (tempDelta > 1f) {
			dressUpSlider.value -= (int)tempDelta;
			intDressUpTimer -= 1;
			tempDelta -= 1;
		}
		if (intDressUpTimer == 0) {
			SceneManager.LoadScene ("LoseScene");
			SceneManager.UnloadSceneAsync ("Scene");
		}
	}
}
