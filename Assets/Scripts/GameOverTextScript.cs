using UnityEngine;
using System.Collections;

public class GameOverTextScript : MonoBehaviour {
	public GUIText msg;
	public GameObject manager;
	// Use this for initialization
	void Start () {
		manager = GameObject.FindGameObjectWithTag ("GameController");
		//msg.text = "Game Over\nNumber of civilians saved: " + manager.civiliansSaved;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
