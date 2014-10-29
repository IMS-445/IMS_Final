using UnityEngine;
using System.Collections.Generic;

public enum NPCReaction {
	AlwaysGiveBucketGeneric,
	SometimesGiveBucket,
	Nothing,

};

public class NPCTalk : MonoBehaviour {
	
	GameObject PlayerChar;
	GUIText myGUIText;


	public float dist;
	public GameObject NPCObject;
	public string talkTextDefault;
	public string talkTextChange;
	public float saveCost = 1.0f;
	public NPCReaction reaction;
	public List<InventoryObject> playerInventory;


	private  TimerScript time;
	public bool saved;

	// Use this for initialization
	void Start () {
		PlayerChar = GameObject.FindGameObjectWithTag ("Player");
		playerInventory = (PlayerChar.GetComponent<ThirdPersonController> ()).GetList();

		GameObject obj = new GameObject("Dummy");
		obj.AddComponent("GUIText");
		myGUIText = obj.guiText;
		myGUIText.enabled = false;
		myGUIText.text = talkTextDefault;
		myGUIText.fontSize = 20;
		myGUIText.anchor = TextAnchor.MiddleCenter;
		obj.transform.position = new Vector3 (0.5f,0.5f,0.0f);
		GameObject TimeParent = GameObject.FindGameObjectWithTag ("Timer");
		time = (TimerScript)TimeParent.GetComponent<TimerScript> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Vector3.Distance (NPCObject.transform.position, PlayerChar.transform.position) < dist) {
			myGUIText.enabled = true;
			if(Input.GetKeyDown (KeyCode.Q) && (saveCost > 0)  && !saved)
			{
				time.timer = time.timer - saveCost;
				saved =true; 
				myGUIText.text = talkTextChange;
				Save();
			}
		} 
		else {
			myGUIText.enabled = false;
		}
	}

	public void Save()
	{
		switch (reaction) {
		case NPCReaction.Nothing:
			break;
		case NPCReaction.SometimesGiveBucket:

			break;
		case NPCReaction.AlwaysGiveBucketGeneric:
			myGUIText.text = "Thank you for saving me!  Here is a bucket!";
			playerInventory.Add(new InventoryObject(1,"Empty_bucket"));
			break;
		}
	}

	public void AddItem(int num, string name){
		InventoryObject obj = playerInventory.Find ((InventoryObject io) => io.name.Equals (name));
		if (obj == null) {
			obj = new InventoryObject(num, name);
			playerInventory.Add(obj);
		} else {
			obj.quantity = obj.quantity + num;
		}
		if (obj.quantity <= 0) {
			playerInventory.Remove(obj);
		}
	}

	public void UpdateList(){
		playerInventory = new List<InventoryObject>();
		(PlayerChar.GetComponent<ThirdPersonController> ()).GetList ().ForEach ((InventoryObject io) => playerInventory.Add (io));
	}

}
