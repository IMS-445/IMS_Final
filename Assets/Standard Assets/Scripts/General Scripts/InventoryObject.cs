using UnityEngine;
using System.Collections;

public class InventoryObject {
	int quantity = 0;
	string name = "name";

	public InventoryObject(){
		// create object
	}

	public InventoryObject(string name){
		this.name = name;
	}

	public InventoryObject(int qty, string name){
		this.quantity = qty;
		this.name = name;
	}

	// Edit the quantity by the signified amount
	public void editQty(int update)
	{
		quantity += update;
	}

	// Get the quantity of an object
	public int getQty()
	{
		return quantity;
	}

	// Not in here, in char controller
//	public bool interact(GameObject obj)
//	{
//		switch(obj.tag)
//		{
//		case "fire" : 
//			InventoryObject io = uinventory.Find(i => i.name == "full_bucket" && i.quantity > 0);
//			if(io != null){
//				Destroy(obj);
//				io.editQty(-1);
//				if(io.getQty <= 0)
//					uinventory.Remove(i => i.name == "full_bucket");
//				InventoryObject bucket = uinventory.Find(i => i.name == "empty_bucket");
//				if(bucket != null)
//					bucket.editQty(1);
//				else
//					uinventory.Add(new InventoryObject("empty_bucket", 1));
//			}
//		}
//	}
}

