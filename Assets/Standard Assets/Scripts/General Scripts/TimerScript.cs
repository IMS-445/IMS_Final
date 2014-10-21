﻿using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
	public float timer = 100.0f;
	public GUIText timerText;

	// Use this for initialization
	void Start () {
		timerText.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
		if (timer > 0) {
			timer -= Time.deltaTime;
		}

		if (timer <= 0) {
			timer = 0;
		}

		int mins = Mathf.FloorToInt (timer / 60F);
		int secs = Mathf.FloorToInt (timer - mins * 60);
		timerText.text = string.Format("{0:0}:{1:00}", mins, secs);

		if (timer == 0) {
			timerText.color = Color.red;
		}
	}
}
