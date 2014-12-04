using UnityEngine;
using System.Collections;

public class TextureMaster : MonoBehaviour {

	public Texture[] Scenes;
	public int counter;
	public string NextScene;
	public GUITexture TextureToShow;
	public double wait;


	// Use this for initialization
	void Start () {
		counter = 0;
		if (Scenes.Length == counter) {
			Application.LoadLevel(NextScene);
		} else {
			TextureToShow.texture = Scenes[counter];
		}
	}
	
	// Update is called once per frame
	void Update () {
		wait = wait - Time.deltaTime;
		if (wait < 0) {
			wait = 0.0f;
		}
		if(Input.anyKeyDown && wait <= 0.0f){
			wait = 1.5f;
			counter++;
			if (Scenes.Length == counter) {
				Application.LoadLevel(NextScene);
			} else {
				TextureToShow.texture = Scenes[counter];
			}
		}
	}
}
