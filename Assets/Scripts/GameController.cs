using UnityEngine;
using System.Collections.Generic;

public class GameController : MonoBehaviour {

	public static GameController control;
	public List<InventoryObject> playerInventory;

	int civiliansSaved;

	// Use this for initialization
	void Awake () {
		playerInventory = new List<InventoryObject> ();
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
}
