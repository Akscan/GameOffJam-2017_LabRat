using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class WinGame : MonoBehaviour {
	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "FPSController") {
			Debug.Log ("Exit!");
			SceneManager.LoadScene ("WinScene");
			SceneManager.UnloadSceneAsync ("Scene");
		}
	}

}
