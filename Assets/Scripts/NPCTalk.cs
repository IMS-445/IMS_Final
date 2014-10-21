using UnityEngine;
using System.Collections;

public class NPCTalk : MonoBehaviour {

	GameObject PlayerChar;
	GUIText myGUIText;


	public int dist;
	public GameObject NPCObject;
	public string talkText;


	// Use this for initialization
	void Start () {
		PlayerChar = GameObject.FindGameObjectWithTag ("Player");
		GameObject obj = new GameObject("Dummy");
		obj.AddComponent("GUIText");
		myGUIText = obj.guiText;
		myGUIText.enabled = false;
		myGUIText.text = talkText;
		myGUIText.fontSize = 20;
		myGUIText.anchor = TextAnchor.MiddleCenter;
		obj.transform.position = new Vector3 (0.5f,0.5f,0.0f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Vector3.Distance (NPCObject.transform.position, PlayerChar.transform.position) < 20.0f) {
			myGUIText.enabled = true;
		} 
		else {
			myGUIText.enabled = false;
		}
	}
}
