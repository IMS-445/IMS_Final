using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {

	void OnGUI () {
		GUIStyle style = new GUIStyle ();
		if (GUI.Button (new Rect (155, 200, 100, 30), "New Game")) {
			Application.LoadLevel("Start");
		}
	}
}
