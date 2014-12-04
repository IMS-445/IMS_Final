using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {

	public GameObject PlayerChar;
	public GameObject followObject;
	public static PlayerFollow playerFollow;

	void Awake() {
		if (playerFollow == null) {
			playerFollow = this;
		}
	}

	// Use this for initialization
	void Start () {
		PlayerChar = GameObject.FindGameObjectWithTag ("PlayerFollow");
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerChar == null) {
			PlayerChar = GameObject.FindGameObjectWithTag ("PlayerFollow");
				}
		if(followObject != null)
		{
			Vector3 idealPosition = PlayerChar.transform.position;
			Vector3 currentPoisition = followObject.gameObject.transform.position;
			float dist = (10f - Vector3.Distance(currentPoisition,idealPosition)) / 10f;
			if(dist > .95f){
				dist = 1f;
			}else{
				dist = .05f;
			}
			followObject.gameObject.transform.position = Vector3.Lerp(currentPoisition,idealPosition,dist);
			//print ( currentPoisition + " " + idealPosition + "  " + dist );
		}
	}

	public void SetAsFollow(GameObject newFollow){
		followObject = newFollow;
	}

	public GameObject getFollow(){
		return followObject;
	}
}