﻿using UnityEngine;
using System.Collections.Generic;

public class InventoryTracker : MonoBehaviour {

	public List<InventoryObject> playerInventory;
	public GUIText inventoryList;
	// Use this for initialization
	void Start () {
		GameObject PlayerChar = GameObject.FindGameObjectWithTag ("Player");
		//playerInventory = (PlayerChar.GetComponent<ThirdPersonController> ()).inventory;
	}
	
	// Update is called once per frame
	void Update () {
		string s ="";
		/*foreach (InventoryObject io in playerInventory) {
			s += io.name + " x" + io.getQty() + "\r\n";
		}
		inventoryList.text = s;*/
	}
}
