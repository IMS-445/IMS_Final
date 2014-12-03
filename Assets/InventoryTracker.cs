using UnityEngine;
using System.Collections.Generic;

public class InventoryTracker : MonoBehaviour {
	public List<InventoryObject> myInventory;
	public GUIText inventoryList;
	public GUITexture icon;

	public Texture2D inventoryPic;
	public Rect inventoryBox;
	// Use this for initialization
	void Start () {
		//GameObject PlayerChar = GameObject.FindGameObjectWithTag ("Player");
		myInventory = GameController.control.playerInventory;
	}

	void onGUI(){
		GUI.DrawTexture (inventoryBox, inventoryPic);
	}
	
	// Update is called once per frame
	void Update () {
		string s ="";
		foreach (InventoryObject io in myInventory) {
			s += "x" + io.getQty() + "\r\n\r\n\r\n";
		}
		inventoryList.text = s;
	}

	void findTexture(){

	}
}
