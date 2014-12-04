using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
		public float timer;
	public GUIText timerText;
	public GameObject people; // Used to get list of all people on the page
	public string nextLevel;

	// Use this for initialization
	void Start () {
		timerText.color = Color.white;
		// Sets the civilian count to the number of child objects in the "people" game object
		// of the layout in the level
		GameController.control.setCiviliansInLevel (people.transform.childCount);
		if (nextLevel == null) {
			nextLevel = "GameOver";
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (timer <= 0) {
			timer = 0;
			GameController.control.adjustGuilt();
			Application.LoadLevel(nextLevel);
		}

		int mins = Mathf.FloorToInt (timer / 60F);
		int secs = Mathf.FloorToInt (timer - mins * 60);
		timerText.text = string.Format("{0:0}:{1:00}", mins, secs);

		if (timer <= 10.9) {
			timerText.color = Color.red;
		}
		if (Input.GetKeyDown (KeyCode.P)) {
			timer = 0.0f;
		}
	}
}
