using UnityEngine;
using System.Collections.Generic;

public enum ObjectAction {
	AlwaysGiveBucketGeneric,
	SometimesGiveBucket,
	Saved,
	Nothing,
	DestroyByFilledBucket,
	FillEmptyBucket
};

public class NPCTalk : MonoBehaviour {
	
	GameObject PlayerChar;
	GUIText myGUIText;


	public float dist;
	public GameObject NPCObject;	
	public string talkTextDefault;
	public string talkTextChange;
	public float actionCost = 1.0f;
	public ObjectAction action;
	public List<InventoryObject> playerInventory;


	private  TimerScript time;
	public bool inactive;

	// Use this for initialization
	void Start () {
		if (NPCObject == null) {
			NPCObject = this.gameObject;
		}
		PlayerChar = GameObject.FindGameObjectWithTag ("Player");
		playerInventory = (PlayerChar.GetComponent<ThirdPersonController> ()).inventory;

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
			if(Input.GetKeyDown (KeyCode.Q) && (actionCost >= 0)  && !inactive && TriggerAction())
			{
				time.timer = time.timer - actionCost;
				//myGUIText.text = talkTextChange;
				//TriggerAction();
			}
		} 
		else {
			myGUIText.enabled = false;
		}
	}

	public bool TriggerAction()
	{
		string workingItem = "";
		switch (action) {
		case ObjectAction.Nothing:
			break;
		case ObjectAction.FillEmptyBucket:
			workingItem = "Empty_bucket";
			if(ContainsItem(workingItem)){
				AddItem(-1, workingItem);
				AddItem(1,"Full_bucket");
			}
			break;
		case ObjectAction.Saved:
			//Make any necessary calls to Game manager

			inactive =true; 
			myGUIText.text = talkTextChange;
			GameObject.Destroy(myGUIText.gameObject, 5);
			GameObject.Destroy(this.gameObject, 5);
			break;
		case ObjectAction.SometimesGiveBucket:

			break;
		case ObjectAction.AlwaysGiveBucketGeneric:
			inactive =true; 
			myGUIText.text = "Thank you for saving me!  Here is a bucket!";
			playerInventory.Add(new InventoryObject(1,"Empty_bucket"));
			GameObject.Destroy(myGUIText.gameObject, 5);
			GameObject.Destroy(this.gameObject, 5);
			break;
		case ObjectAction.DestroyByFilledBucket:
			workingItem = "Full_bucket";
			if(ContainsItem(workingItem)){
				AddItem(-1,workingItem);
				AddItem(1,"Empty_bucket");
				time.timer = time.timer - actionCost;  //This occurs here because of the deletion.
				GameObject.Destroy(myGUIText.gameObject);
				GameObject.Destroy(this.gameObject);
			}
			break;
		}
		return true;
	}

	void AddItem(int num, string name){
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

	bool ContainsItem(string name){
		InventoryObject obj = playerInventory.Find ((InventoryObject io) => io.name.Equals (name));
		if (obj == null) {
				return false;
		} else {
				return true;
		}
	}

	public void UpdateList(){
		//playerInventory = new List<InventoryObject>();
		//(PlayerChar.GetComponent<ThirdPersonController> ()).GetList ().ForEach ((InventoryObject io) => playerInventory.Add (io));
	}

}
