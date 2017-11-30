using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {
	AudioSource firstSound;
	public AudioClip firstClip;
	void OnTriggerExit(Collider other)
	{
		firstSound = GetComponent<AudioSource> ();
		firstSound.clip = firstClip;
		firstSound.Play ();
	}

}
