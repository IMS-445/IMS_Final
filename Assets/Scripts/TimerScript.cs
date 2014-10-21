using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
	public float timer;
	public GUIText timerText;

	// Use this for initialization
	void Start () {
		timer = 100.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		//timerText.text = timer.ToString();
		timerText.text = (timer/60).ToString("f0") + ":" + (timer%60).ToString("f0");
	}
}
