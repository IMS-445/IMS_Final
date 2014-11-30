using UnityEngine;
using System.Collections.Generic;

public class InventoryTracker : MonoBehaviour {
	public List<InventoryObject> myInventory;
	public GUIText inventoryList;
	public GUITexture icon;
	// Use this for initialization
	void Start () {
		//GameObject PlayerChar = GameObject.FindGameObjectWithTag ("Player");
		myInventory = GameController.control.playerInventory;
		icon = inventoryList.GetComponent<GUITexture> ();
		icon.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		string s ="";
		foreach (InventoryObject io in myInventory) {
			s += "x" + io.getQty() + "\r\n\r\n";
			icon.enabled = true;
		}
		inventoryList.text = s;
	}

	void findTexture(){

	}
}
