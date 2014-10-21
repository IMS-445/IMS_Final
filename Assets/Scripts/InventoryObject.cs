using UnityEngine;
using System.Collections;

public class InventoryObject {
	int quantity = 0;
	string name = "name";

	public InventoryObject(){
		// create object
	}

	public InventoryObject(int qty, string name){
		this.quantity = qty;
		this.name = name;
	}


}
