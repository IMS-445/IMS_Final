using UnityEngine;
using System.Collections;

public class DestroyOnTouch : MonoBehaviour {

	public GameObject ToDestroy;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		print ("hello!");
		if (other.tag == "Player") {
			Destroy (ToDestroy);
		}
	}
}
