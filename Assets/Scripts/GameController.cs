using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static GameController control;
	public List<InventoryObject> playerInventory;

	int civiliansSaved;
	float guilt;
	int civiliansInLevel;

	public float guiltModifier = 1.0f;

	// Use this for initialization
	void Awake () {
		playerInventory = new List<InventoryObject> ();
		// Add items initially
		playerInventory.Add (new InventoryObject (0, "Empty bucket"));
		playerInventory.Add (new InventoryObject (0, "Full bucket"));
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this)
			Destroy (gameObject);
		//civiliansSaved = 0;
	}



	//void OnGUI(){
	//	GUI.Label (new Rect (10, 10, 100, 30), "Civilians saved: " + civiliansSaved);
	//}

	public void incrementCivilians(){
		civiliansSaved++;
	}

	public int getCiviliansSaved(){
		return civiliansSaved;
	}

	public void setCiviliansInLevel(int i){
		civiliansInLevel = i;
	}

	public void adjustGuilt(){
		guilt += (civiliansInLevel - civiliansSaved) * guiltModifier * 0.1F;
	}

	public float getGuilt(){
		return guilt;
	}
}
