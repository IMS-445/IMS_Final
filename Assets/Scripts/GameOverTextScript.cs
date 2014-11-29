using UnityEngine;
using System.Collections;

public class GameOverTextScript : MonoBehaviour {
	public GUIText msg;
	// Use this for initialization
	void Start () {
		//manager = GameObject.FindGameObjectWithTag ("GameController");
		msg.text = "Number of civilians saved: " + GameController.control.getCiviliansSaved ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
