using UnityEngine;
using System.Collections.Generic;

public class InventoryTracker : MonoBehaviour {
	public GameObject gameController;
	public List<InventoryObject> myInventory;
	public GUIText inventoryList;
	// Use this for initialization
	void Start () {
		//GameObject PlayerChar = GameObject.FindGameObjectWithTag ("Player");
		myInventory = (gameController.GetComponent<GameController> ()).playerInventory;
	}
	
	// Update is called once per frame
	void Update () {
		string s ="";
		if (myInventory == null) {
			myInventory = (gameController.GetComponent<GameController> ()).playerInventory;
		}
		foreach (InventoryObject io in myInventory) {
			s += io.name + " x" + io.getQty() + "\r\n";
		}
		inventoryList.text = s;
	}
}
