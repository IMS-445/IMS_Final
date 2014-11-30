using UnityEngine;
using System.Collections;

public class guistuff : MonoBehaviour {
    string startingLevel;
	// Use this for initialization
	void Start () {
        startingLevel = Application.loadedLevelName;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(10, 10, 100, 90), startingLevel);
    }
}
