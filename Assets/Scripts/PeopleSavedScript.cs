using UnityEngine;
using System.Collections;

public class PeopleSavedScript : MonoBehaviour {
	public GUIText savedText;
	public int savedNumber = 0;

	// Use this for initialization
	void Start () {
		savedText.color = Color.white;
		savedNumber = 0;
	}
	
	// Update is called once per frame
	void Update () {
		savedText.text = "People Saved: " + GameController.control.getCiviliansSaved();
	}

	public void AddSavedPerson(){
		savedNumber++;
	}
}
