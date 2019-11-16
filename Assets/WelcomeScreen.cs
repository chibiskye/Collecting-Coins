using UnityEngine;
using System.Collections;

public class WelcomeScreen : MonoBehaviour {

	void OnGUI() {
		if (GUI.Button(new Rect(325, 500, 150, 50), "Start")) {
			Application.LoadLevel("CollectingCoins");
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
